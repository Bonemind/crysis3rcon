using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Org.JZhao.Crysis.ServerToolkit;
using System.Runtime.InteropServices;
using System.Timers;
using System.Net;

namespace Crysis3Rcon
{
    public partial class Form1 : Form
    {
        CrysisServerSession css;
        System.Timers.Timer timer;

        /// <summary>
        /// Form 1 constructor, creates the timer for the refreshing of the server status
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.Interval = 1000 * 60 * 5;
            timer.Elapsed += new ElapsedEventHandler(refreshPlayerTimer);
        }

        /// <summary>
        /// Handles the player refresh event
        /// </summary>
        /// <param name="sender">The event-raiser</param>
        /// <param name="e">Event arguments raised by the timer 'timer'</param>
        private void refreshPlayerTimer(object sender, EventArgs e)
        {
            repopulatePlayerBox();
        }

        /// <summary>
        /// Handles the connecting to the server when a player clicks a button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connect_Click(object sender, EventArgs e)
        {
            //Input validation is done here
            int parsedPort;
            bool validPort = int.TryParse(portNum.Text, out parsedPort);
            IPAddress[] addres;
            try
            {
                addres = Dns.GetHostAddresses(ipAdress.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("That serveraddres could not be found", "Addres invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            ipAdress.Text = addres[0].ToString();
            if (!validPort)
            {
                MessageBox.Show("That is not a valid port number :(", "Portnumber invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Actual connecting is done here
            css = new CrysisServerSession(addres[0].ToString(), parsedPort, passWord.Text, false);
            
            if (css.TestConnection() == false)
            {
                MessageBox.Show("Something went wrong :(");
                css = null;
            }
            else
            {
                console.Text = "Connected to " + ipAdress.Text;
                timer.Start();
                repopulatePlayerBox();
            }
        }

        /// <summary>
        /// Grabs the input of the command textbox, executes that command on the server,
        /// Then appends the serverreply to the console textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void execute_Click(object sender, EventArgs e)
        {
            if (css != null)
            {
                console.Text += "\r\n" + css.ExecuteCommand(command.Text);
                console.SelectionStart = console.Text.Length;
                console.ScrollToCaret();
            }
        }

        /// <summary>
        /// Refreshes the playerlist on request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statusButton_Click(object sender, EventArgs e)
        {
            repopulatePlayerBox();
        }

        /// <summary>
        /// Repopulates the playerlist,
        /// Grabs a list of players from the server and adds them to the player listbox
        /// </summary>
        private void repopulatePlayerBox()
        {
            if (css != null)
            {
                List<Player> playerList = css.GetPlayers();
                playerBox.Items.Clear();
                foreach (Player player in playerList)
                {
                    playerBox.Items.Add(player);
                }
                console.AppendText("\r\nPlayerlist refreshed\r\n");
                playerCount.Text = "Players: " + playerList.Count;
            }
        }

        /// <summary>
        /// Handles the kicking of a player,
        /// Sends a kick 'playername' command to the server,
        /// Playername is retrieved from the selected item in the player listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kickButton_Click(object sender, EventArgs e)
        {
            if (css != null)
            {
                Player kickPlayer = (Player)playerBox.SelectedItem;
                css.ExecuteCommand("kick " + kickPlayer.Name);
            }
        }

        /// <summary>
        /// Handles the banning of a player,
        /// Sends a ban 'playername' command to the server,
        /// Playername is retrieved from the selected item in the player listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void banButton_Click(object sender, EventArgs e)
        {
            if (css != null)
            {
                Player banPlayer = (Player)playerBox.SelectedItem;
                css.ExecuteCommand("ban " + banPlayer.Name);
            }
        }

        /// <summary>
        /// When form1 loads, the server address textbox, port textbox, and password textbox are
        /// filled with the saved settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ipAdress.Text = Properties.Settings.Default.Server;
            portNum.Text = Properties.Settings.Default.Port;
            passWord.Text = Properties.Settings.Default.Password;
        }

        /// <summary>
        /// The current servername, port and password are saved to make persistent settings possible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Server = ipAdress.Text;
            Properties.Settings.Default.Port = portNum.Text;
            Properties.Settings.Default.Password = passWord.Text;
            Properties.Settings.Default.Save();
        }
    }
}
