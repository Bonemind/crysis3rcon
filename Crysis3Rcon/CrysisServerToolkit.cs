using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Runtime.CompilerServices;
namespace Org.JZhao.Crysis.ServerToolkit
{
    public class CrysisServerSession
    {
        #region Private Fields
        private string ip;
        private int port;
        private string password;
        private TcpClient tcpClient;
        //if any of the fields is changed, it's dirtied  
        private bool isDirty;
        private bool cacheConnection;

        #endregion
        /// <summary>
        /// Creates a new Crysis server session. This does not initate a connection
        /// </summary>
        /// <param name="ip">IP of the game server</param>
        /// <param name="port">Port of the HTTP server in the game server 
        /// (http_start port:port)</param>
        /// <param name="password">Password to the http server. 
        /// (http_password password)</param>
        public CrysisServerSession(string ip, int port, string password)
            : this(ip, port, password, true)
        {
        }
        /// <summary>
        /// Creates a new Crysis server session. This does not initate a connection
        /// </summary>
        /// <param name="ip">IP of the game server</param>
        /// <param name="port">Port of the HTTP server in the game server 
        /// (http_start port:port)</param>
        /// <param name="password">Password to the http server. 
        /// (http_password password)</param>
        /// <param name="cacheConnection">If cachConnection is set to true, all commands 
        /// will try to use the same connection.</param>
        public CrysisServerSession(string ip, int port, string password, bool cacheConnection)
        {
            this.ip = ip;
            this.port = port;
            this.password = password;
            this.cacheConnection = cacheConnection;
            if (cacheConnection)
            {
                isDirty = true;
            }
            else
            {
                isDirty = false;
            }
        }
        #region API
        /// <summary>
        /// Closes the session and the underlying TcpClient
        /// </summary>
        public void Close()
        {
            if (cacheConnection && tcpClient != null)
            {
                tcpClient.Close();
            }
        }
        /// <summary>
        /// The IP of the game server
        /// </summary>
        public string IP
        {
            get { return ip; }
            set
            {
                if (!value.Equals(ip))
                {
                    ip = value;
                    isDirty = true;
                }
            }
        }
        /// <summary>
        /// The port of the game server's http server 
        /// (http_startserver port:port)
        /// </summary>
        public int Port
        {
            get { return port; }
            set
            {
                if (!value.Equals(port))
                {
                    port = value;
                    isDirty = true;
                }
            }
        }
        /// <summary>
        /// Password to the http server. 
        /// (http_password password)
        /// </summary>
        public string Password
        {
            get { return password; }
            set
            {
                if (!value.Equals(password))
                {
                    password = value;
                    isDirty = true;
                }
            }
        }
        /// <summary>
        /// Resets the underlying connection if CacheConnection is true
        /// </summary>
        public void Reset()
        {
            if (cacheConnection && tcpClient != null)
            {
                tcpClient.Close();
                isDirty = true;
            }
        }
        /// <summary>
        /// If cachConnection is set to true, all commands will try to use the same connection.
        /// </summary>
        public bool CacheConnection
        {
            get { return cacheConnection; }
            set
            {
                cacheConnection = value;
                if (cacheConnection)
                {
                    isDirty = true;
                }
                else
                {
                    isDirty = false;
                    if (tcpClient != null)
                        tcpClient.Close();
                }
            }
        }
        /// <summary>
        /// Executes a command on the server and return an unformatted response
        /// This method is synchronized to prevent multiple thread accessing it at same time
        /// </summary>
        /// <param name="command">The command to execute</param>
        /// <returns>An unformatted response. 
        /// Only the XML wrapper and the HTTP headers are stripped out.</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public string ExecuteCommand(string command)
        {
            bool isAuthenticated = false;
            if (cacheConnection == true && isDirty == true)
            {
                if (tcpClient != null)
                {
                    tcpClient.Close();
                }
                tcpClient = new TcpClient(ip, port);
                tcpClient.ReceiveTimeout = 3000;
                isAuthenticated = CrysisServerUtils.Authenticate(tcpClient, password);
                if (isAuthenticated)
                {
                    isDirty = false;
                }
                else
                {
                    tcpClient.Close();
                }
            }
            else if (cacheConnection == true && isDirty == false)
            {
                if (tcpClient.Connected)
                {
                    isAuthenticated = true;
                }
                else
                {
                    //make sure the connection didn't die off
                    tcpClient = new TcpClient(ip, port);
                    isAuthenticated = CrysisServerUtils.Authenticate(tcpClient, password);
                    if (!isAuthenticated)
                    {
                        isDirty = true;
                    }
                }
            }
            else if (cacheConnection == false)
            {
                tcpClient = new TcpClient(ip, port);
                tcpClient.ReceiveTimeout = 3000;
                isAuthenticated = CrysisServerUtils.Authenticate(tcpClient, password);
               
            }
            if (isAuthenticated)
            {
                //if authentication was successful
                CrysisServerUtils.PostCommand(tcpClient, command);
                string result = CrysisServerUtils.GetResult(tcpClient);
                if (!cacheConnection)
                {
                    tcpClient.Close();
                }
                return result;
            }
            else
            {
                throw new AuthenticationException("Authentication Failed with password:" + password);
            }

        }
        /// <summary>
        /// Async version of ExecuteCommand. 
        /// Executes a command on the server and return an unformatted response
        /// This method is synchronized to prevent multiple thread accessing it at same time
        /// </summary>
        /// <param name="command">The command to execute</param>
        /// <returns></returns>
        public Result ExecuteCommandAsync(string command)
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    r.Value = ExecuteCommand(command);
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        /// <summary>
        /// Say something on the server. Executed "sv_say" behind the scenes
        /// </summary>
        /// <param name="text">The text to say</param>
        public void Say(string text)
        {
            Console.WriteLine("said " + text);
            ExecuteCommand("sv_say " + text);
        }
        /// <summary>
        /// Async version of SayAsync.
        /// Say something on the server. Executed "sv_say" behind the scenes
        /// </summary>
        /// <param name="text">The text to say</param>
        public Result SayAsync(string text)
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    Say(text);
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }

        /// <summary>
        /// Tests the ip/port/password are correct by sending a sv_port command
        /// </summary>
        /// <returns>True if the connection is valid, false otherwise</returns>
        public bool TestConnection()
        {
            try
            {
                ExecuteCommand("sv_port");
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Async version of TestConnection.
        /// Tests the ip/port/password are correct by sending a sv_port command
        /// </summary>
        /// <returns>True if the connection is valid, false otherwise</returns>
        public Result TestConnectionAsync()
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    r.Value = TestConnection();
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }

        #region Kick and Bans
        /// <summary>
        /// Kicks player using their ID
        /// </summary>
        /// <param name="player">The player to kick</param>
        public void Kick(Player player)
        {
            if (player == null)
                throw new ArgumentException("player is null");
            ExecuteCommand("kickid " + player.ID);
        }
        /// <summary>
        /// Async version of Kick.
        /// Kicks player using their ID
        /// </summary>
        /// <param name="player">The player to kick</param>
        public Result KickAsync(Player player)
        {
            Result result = new Result();
            ThreadStart starter = delegate
            {
                result.Status = AsyncCallStatus.Running;
                try
                {
                    Kick(player);
                }
                catch (Exception e)
                {
                    result.Status = AsyncCallStatus.Error;
                    result.Value = e;
                }
                result.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return result;
        }
        /// <summary>
        /// Bans player using their profile
        /// </summary>
        /// <param name="player">The player to ban</param>
        public void Ban(Player player)
        {
            if (player == null)
                throw new ArgumentException("player is null");
            ExecuteCommand("ban " + player.Profile);
        }
        /// <summary>
        /// Async version of Ban.
        /// Bans player using their profile
        /// </summary>
        /// <param name="player">The player to ban</param>
        public Result BanAsync(Player p)
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    BanAsync(p);
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        #endregion
        /// <summary>
        /// Gets a list of players by sending a status command.
        /// If a player is still connecting, their state will be "PlayerConnectionState.Connecting";
        /// Otherwise it will be "Crysis.PlayerConnectionState.Connected".
        /// </summary>
        /// <returns>A list of players on the server.</returns>
        public List<Player> GetPlayers()
        {
            string status = Status();
            if (status.Contains("Connection Status:") == false)
            {
                //no players
                return new List<Player>();
            }
            List<Player> playerList = new List<Player>();
            string[] playerStringList = (status.Split(new string[] { "Connection Status:" }
                , StringSplitOptions.RemoveEmptyEntries)[1]).
                Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string ps in playerStringList)
            {
                Player p = Player.Build(ps.Trim());
                playerList.Add(p);
            }
            return playerList;
        }
        /// <summary>
        /// Async version of GetPlayers.
        /// Gets a list of players by sending a status command.
        /// If a player is still connecting, their state will be "PlayerConnectionState.Connecting";
        /// Otherwise it will be "Crysis.PlayerConnectionState.Connected".
        /// </summary>
        /// <returns>A list of players on the server.</returns>
        public Result GetPlayersAsync()
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    r.Value = GetPlayers();
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        /// <summary>
        /// Executed a status command
        /// </summary>
        /// <returns>The result of the status</returns>
        public string Status()
        {
            return ExecuteCommand("status");
        }
        /// <summary>
        /// Async version of Status.
        /// Executed a status command
        /// </summary>
        /// <returns>The result of the status</returns>
        public Result StatusAsync()
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    r.Value = Status();
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        /// <summary>
        /// Sets the damage amount of friendly fire. 
        /// </summary>
        /// <param name="value">The damage amount caused by friendly fire.
        /// 0.0 means no team damage. 1.0 means same damage as enemy fire</param>
        public void SetFriendlyFireRatio(double value)
        {
            ExecuteCommand("g_friendlyfireratio " + value.ToString());
        }
        /// <summary>
        /// Gets the damage amount of friendly fire. 
        /// </summary>
        /// <returns>The damage amount caused by friendly fire.
        /// 0.0 means no team damage. 1.0 means same damage as enemy fire</returns>
        public double GetFriendlyFireRatio()
        {
            string[] lines = CrysisServerUtils.BlockToLines(ExecuteCommand("g_friendlyfireratio"));
            return Double.Parse(CrysisServerUtils.DecomposeEqual(lines[0])[1].Trim());
        }
        /// <summary>
        /// Async version of SetFriendlyFireRatio.
        /// Sets the damage amount of friendly fire. 
        /// </summary>
        /// <param name="value">The damage amount caused by friendly fire.
        /// 0.0 means no team damage. 1.0 means same damage as enemy fire</param>
        public Result SetFriendlyFireRatioAsync(double value)
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    SetFriendlyFireRatio(value);
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        /// <summary>
        /// Async version of GetFriendlyFireRatio.
        /// Gets the damage amount of friendly fire. 
        /// </summary>
        /// <returns>The damage amount caused by friendly fire.
        /// 0.0 means no team damage. 1.0 means same damage as enemy fire</returns>
        public Result GetFriendlyFireRatioAsync()
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    r.Value = GetFriendlyFireRatio();
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        /// <summary>
        /// Sets the number of team kills a user will be banned for.
        /// </summary>
        /// <param name="value">Number of team kills a user will be banned for.</param>
        public void SetTKPunishLimit(int value)
        {
            ExecuteCommand("g_tk_punish_limit " + value);
        }
        /// <summary>
        /// Gets the number of team kills a user will be banned for.
        /// </summary>
        /// <returns>Number of team kills a user will be banned for.</returns>
        public int GetTKPunishLimit()
        {
            string[] lines = CrysisServerUtils.BlockToLines(ExecuteCommand("g_tk_punish_limit"));
            return int.Parse(CrysisServerUtils.DecomposeEqual(lines[0])[1].Trim());
        }
        /// <summary>
        /// Async version of SetTKPunishLimit.
        /// Sets the number of team kills a user will be banned for.
        /// </summary>
        /// <param name="value">Number of team kills a user will be banned for.</param>
        public Result SetTKPunishLimitAsync(int value)
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    SetTKPunishLimit(value);
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        /// <summary>
        /// Async version of GetTKPunishLimit.
        /// Gets the number of team kills a user will be banned for.
        /// </summary>
        /// <returns>Number of team kills a user will be banned for.</returns>
        public Result GetTKPunishLimitAsync()
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    r.Value = GetTKPunishLimit();
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        /// <summary>
        /// Gets if team kill punishment is allowed.
        /// </summary>
        /// <returns>If team kill punishment is allowed.</returns>
        public bool GetTKPunish()
        {
            string[] lines = CrysisServerUtils.BlockToLines(ExecuteCommand("g_tk_punish"));
            return CrysisServerUtils.DecomposeEqual(lines[0])[1].Trim().Equals("1") ? true : false;
        }
        /// <summary>
        /// Sets if team kill punishment is allowed.
        /// </summary>
        /// <param name="value">If team kill punishment is allowed.</param>
        public void SetTKPunish(bool value)
        {
            ExecuteCommand("g_tk_punish " + (value ? 1 : 0).ToString());
        }
        /// <summary>
        /// Asynv version of GetTKPunish
        /// Gets if team kill punishment is allowed.
        /// </summary>
        /// <returns>If team kill punishment is allowed.</returns>
        public Result GetTKPunishAsync()
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    r.Value = GetTKPunish();
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        /// <summary>
        /// Async version of SetTKPunish.
        /// Sets if team kill punishment is allowed.
        /// </summary>
        /// <param name="value">If team kill punishment is allowed.</param>
        public Result SetTKPunishAsync(bool value)
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    SetTKPunish(value);
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }

        public int GetTeamBalanceValue()
        {
            string[] lines = CrysisServerUtils.BlockToLines(ExecuteCommand("g_teamlock"));
            return int.Parse(CrysisServerUtils.DecomposeEqual(lines[0])[1].Trim());
        }
        public void SetTeamBalanceValue(int value)
        {
            ExecuteCommand("g_teamlock " + value);
        }
        public Result GetTeamBalanceValueAsync()
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    r.Value = GetTeamBalanceValue();
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        public Result SetTeamBalanceValueAsync(int value)
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    SetTeamBalanceValue(value);
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }

        public string GetCurrentMap()
        {
            string[] lines = CrysisServerUtils.BlockToLines(ExecuteCommand("sv_map"));
            if (lines.Length == 2)
            {
                return CrysisServerUtils.DecomposeEqual(lines[1])[1].Trim();
            }
            else
            {
                string message ="";
                foreach (string line in lines)
                {
                    message += line;
                }
                return message;
            }
        }
        public void SetCurrentMap(string value)
        {
            ExecuteCommand("map " + value);
        }
        public Result GetCurrentMapAsync()
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    r.Value = GetCurrentMap();
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        public Result SetCurrentMapAsync(string value)
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    SetCurrentMap(value);
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }

        public void SetServerName(string value)
        {
            ExecuteCommand("sv_servername " + value);
        }
        public string GetServerName()
        {
            string[] lines = CrysisServerUtils.BlockToLines(ExecuteCommand("sv_servername"));
            return CrysisServerUtils.DecomposeEqual(lines[0])[1].Trim();
        }
        public Result SetServerNameAsync(string value)
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    SetServerName(value);
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        public Result GetServerNameAsync()
        {
            Result r = new Result();
            ThreadStart starter = delegate
            {
                r.Status = AsyncCallStatus.Running;
                try
                {
                    r.Value = GetServerName();
                }
                catch (Exception e)
                {
                    r.Status = AsyncCallStatus.Error;
                    r.Value = e;
                }
                r.Status = AsyncCallStatus.Done;
            };
            new Thread(starter).Start();
            return r;
        }
        #endregion
    }
    #region Supporting Classes
    static class CrysisServerUtils
    {
        public static bool Authenticate(TcpClient tc, string password)
        {
            CrysisServerUtils.PostCommand(tc, "challenge");
            string challenge = CrysisServerUtils.GetResult(tc);
            CrysisServerUtils.PostCommand(tc, "authenticate " +
                CrysisServerUtils.GenerateAuthenticationResponse(challenge, password));
            string result = CrysisServerUtils.GetResult(tc);
            if (result == "authorized")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string RemoveEmptyBracketPairs(string val)
        {
            return val.Replace(@"[]", "");
        }
        public static string RemoveDumpToDisk(string val)
        {
            return val.Replace(@"[DUMPTODISK]", "");
        }
        /// <summary>
        /// Converts a block of text to line delimited and remove blank lines
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string[] BlockToLines(string val)
        {
            return val.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
        /// <summary>
        /// Splits the string at the equal sign
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string[] DecomposeEqual(string val)
        {
            return val.Split(new char[] { '=' });
        }
        /// <summary>
        /// This gets the resulting response, without any formatting, from the tcpclient. 
        /// It assumes an command has already been posted with PostCommand
        /// </summary>
        /// <param name="tc">the tcpclient to use</param>
        /// <returns></returns>
        public static string GetResult(TcpClient tc)
        {
            StreamReader sr = new StreamReader(tc.GetStream());
            int bytesToRead;
            string content = sr.ReadLine();
            while (content.Contains("Content-Length") == false)
            {
                content = sr.ReadLine();
            }
            string lengthString = content;
            string[] splitLengthString = lengthString.Split(new char[] { ':' });
            bytesToRead = int.Parse(splitLengthString[1]);
            content= sr.ReadLine();
            while (content != "")
            {
                content = sr.ReadLine();
            }
            char[] buf = new char[bytesToRead];
            sr.ReadBlock(buf, 0, bytesToRead);
            string xmlString = new string(buf);
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xmlString);
            if (xdoc["methodResponse"]["params"]["param"]["value"]["string"].ChildNodes.Count == 0)
            {
                //there's no result
                return "";
            }
            else
            {
                string result = xdoc["methodResponse"]["params"]["param"]["value"]["string"].ChildNodes[0].Value;
                //remove the $ signs
                //Console.WriteLine(result);
                result = Regex.Replace(result, @"\$.", "");
                result = CrysisServerUtils.RemoveDumpToDisk(result);
                result = CrysisServerUtils.RemoveEmptyBracketPairs(result);
                return result;
            }
        }
        /// <summary>
        /// Does a post operation with the command. This does not authenticate by itself.
        /// </summary>
        /// <param name="tc">The TcpClient to use</param>
        /// <param name="cmd">The actual command to send</param>
        public static void PostCommand(TcpClient tc, string cmd)
        {
            string xmlCommand = GetRPCXML(cmd);
            string httpRequest = GetHttpHeader(xmlCommand) + xmlCommand;
            StreamWriter sw = new StreamWriter(tc.GetStream());
            sw.Write(httpRequest);
            sw.Flush();
        }
        /// <summary>
        /// Formats a XML document for a XML-RPC call
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static string GetRPCXML(string cmd)
        {
            return "<?xml version=\"1.0\" encoding=\"UTF-8\"?><methodCall><methodName>" +
                cmd +
                "</methodName><params/></methodCall>";
        }
        /// <summary>
        /// Creates the HTTP headers for the XML-RPC call
        /// </summary>
        /// <param name="xmlCommand">The whole xml command string. 
        /// This is used to caculate the Content-Length parameter</param>
        /// <returns></returns>
        public static string GetHttpHeader(string xmlCommand)
        {
            string header = "POST /RPC2 HTTP/1.1" +
                "\r\nContent-Type: text/xml" +
                "\r\nContent-Length: " + xmlCommand.Length +
                "\r\n\r\n";
            return header;
        }
        /// <summary>
        /// This generates the hash returned to the server to authenticate
        /// </summary>
        /// <param name="challenge">The string passed back after calling "challenge".</param>
        /// <param name="password">The user password.</param>
        /// <returns></returns>
        public static string GenerateAuthenticationResponse(string challenge, string password)
        {
            MD5 md5 = MD5.Create();
            String composed = (new StringBuilder()).Append(challenge).Append(":").Append(password).ToString();
            byte[] hash = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(composed));
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

    }
    public class Player
    {
        public Player()
        {
        }
        public override string ToString()
        {
            return this.Name;
        }
        public static Player Build(string playerString)
        {
            Player player = new Player();
            if (playerString == null || playerString.Equals(""))
                throw new ArgumentException("playerString is null or blank");
            string[] kvs = playerString.Split(new char[] { ' ', ':' },
                StringSplitOptions.RemoveEmptyEntries);
            //This may be needed in the future to create a proper player object
            /**
            foreach (string kv in kvs)
            {
                Console.WriteLine(kv);
            }**/
            //return null;
            //if the player is still connecting
            if (kvs[1].Trim() == "id")
            {
                player.State = PlayerConnectionState.Connecting;
                return player;
            }
            else
            {

                player.State = PlayerConnectionState.Connected;
                player.Name = kvs[1].Trim();
                player.ID = int.Parse(kvs[3]);
                player.IP = "0.0.0.0";
                player.Port = 0;
                player.Ping = int.Parse(kvs[7]);
                player.Profile = kvs[11].Trim();
                return player;
            }
        }
        public int ID;
        public string Name;
        public string IP;
        public string Profile;
        //we use long to stop ovreflow
        public int Ping;
        public int Port;
        public PlayerConnectionState State;
    }
    public enum PlayerConnectionState
    {
        Connecting,
        Connected
    }
    public class AuthenticationException : Exception
    {
        public AuthenticationException() : base() { }
        public AuthenticationException(string msg) : base(msg) { }
    }
    public class Result
    {
        //those are declared volatile b/c multiple threads may access them
        public volatile AsyncCallStatus Status;
        //if there's an error, Value is the exception
        public volatile object Value;
    }
    public enum AsyncCallStatus
    {
        Running,
        Error,
        Done
    }
    #endregion
}
