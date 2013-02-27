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

        public Form1()
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.Interval = 1000 * 60 * 5;
            timer.Elapsed += new ElapsedEventHandler(refreshPlayerTimer);
        }

        private void refreshPlayerTimer(object sender, EventArgs e)
        {
            repopulatePlayerBox();
        }

        private void connect_Click(object sender, EventArgs e)
        {
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
                css.CacheConnection = true;
                repopulatePlayerBox();
            }
        }

        private void execute_Click(object sender, EventArgs e)
        {
            if (css != null)
            {
                console.Text += "\r\n" + css.ExecuteCommand(command.Text);
                console.SelectionStart = console.Text.Length;
                console.ScrollToCaret();
            }
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            repopulatePlayerBox();
        }

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
            }
        }

        private void kickButton_Click(object sender, EventArgs e)
        {
            if (css != null)
            {
                Player kickPlayer = (Player)playerBox.SelectedItem;
                css.ExecuteCommand("kick " + kickPlayer.Name);
            }
        }

        private void banButton_Click(object sender, EventArgs e)
        {
            if (css != null)
            {
                Player banPlayer = (Player)playerBox.SelectedItem;
                css.ExecuteCommand("ban " + banPlayer.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ipAdress.Text = Properties.Settings.Default.Server;
            portNum.Text = Properties.Settings.Default.Port;
            passWord.Text = Properties.Settings.Default.Password;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Server = ipAdress.Text;
            Properties.Settings.Default.Port = portNum.Text;
            Properties.Settings.Default.Password = passWord.Text;
            Properties.Settings.Default.Save();
        }
    }
}
