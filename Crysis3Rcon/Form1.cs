using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Org.JZhao.Crysis.ServerToolkit;
using System.Threading;
using System.Runtime.InteropServices;

namespace Crysis3Rcon
{
    public partial class Form1 : Form
    {
        CrysisServerSession css;

        public Form1()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            css = new CrysisServerSession(ipAdress.Text, int.Parse(portNum.Text), passWord.Text, false);
            console.Text = ipAdress.Text;
            console.AppendText((string) int.Parse(portNum.Text).ToString());
            console.AppendText(passWord.Text);
            if (css.TestConnection() == false)
            {
                MessageBox.Show("Something went wrong :(");
                css = null;
            }
            else
            {
                console.Text = "Connected to " + ipAdress.Text;
            }
        }

        private void execute_Click(object sender, EventArgs e)
        {
            console.Text += "\r\n" + css.ExecuteCommand(command.Text);
            console.SelectionStart = console.Text.Length;
            console.ScrollToCaret();
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            List<Player> playerList = css.GetPlayers();
            playerBox.Items.Clear();
            foreach (Player player in playerList)
            {
                playerBox.Items.Add(player);
            }
        }

        private void playerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kickButton_Click(object sender, EventArgs e)
        {
            Player kickPlayer = (Player) playerBox.SelectedItem;
            css.ExecuteCommand("kick " + kickPlayer.Name);
        }

        private void banButton_Click(object sender, EventArgs e)
        {
            Player banPlayer = (Player)playerBox.SelectedItem;
            css.ExecuteCommand("ban " + banPlayer.Name);
        }
    }
}
