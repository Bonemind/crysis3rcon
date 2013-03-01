namespace Crysis3Rcon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connect = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.TextBox();
            this.command = new System.Windows.Forms.TextBox();
            this.execute = new System.Windows.Forms.Button();
            this.statusButton = new System.Windows.Forms.Button();
            this.playerBox = new System.Windows.Forms.ListBox();
            this.kickButton = new System.Windows.Forms.Button();
            this.banButton = new System.Windows.Forms.Button();
            this.playerCount = new System.Windows.Forms.Label();
            this.serverTabControl = new System.Windows.Forms.TabControl();
            this.serverTab = new System.Windows.Forms.TabPage();
            this.messageRotationTab = new System.Windows.Forms.TabPage();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.g_messageOfTheDay = new System.Windows.Forms.TextBox();
            this.g_serverImageUrl = new System.Windows.Forms.TextBox();
            this.sv_servername = new System.Windows.Forms.TextBox();
            this.ban_timeout = new System.Windows.Forms.TextBox();
            this.net_reserved_slot_system = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.sv_votingTimeout = new System.Windows.Forms.TextBox();
            this.sv_votingEnable = new System.Windows.Forms.TextBox();
            this.sv_votingBanTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.sv_votingRatio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.g_switchTeamUnbalancedWarningTimer = new System.Windows.Forms.TextBox();
            this.sv_password = new System.Windows.Forms.TextBox();
            this.sv_votingCooldown = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.g_switchTeamUnbalancedWarningDifference = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.g_switchTeamRequiredPlayerDifference = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.g_switchTeamAllowed = new System.Windows.Forms.TextBox();
            this.g_idlekicktime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sv_maxPlayers = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.g_pinglimittimer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.g_pinglimit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.g_gameRules_startTimerLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gl_time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gl_initialTime = new System.Windows.Forms.TextBox();
            this.g_autoAssignTeams = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.autorefreshTime = new System.Windows.Forms.TextBox();
            this.ipAdress = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.portNum = new System.Windows.Forms.TextBox();
            this.serverTabControl.SuspendLayout();
            this.serverTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(340, 19);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 3;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(3, 85);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.console.Size = new System.Drawing.Size(412, 351);
            this.console.TabIndex = 4;
            // 
            // command
            // 
            this.command.Location = new System.Drawing.Point(3, 54);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(319, 20);
            this.command.TabIndex = 5;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(340, 56);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(75, 23);
            this.execute.TabIndex = 6;
            this.execute.Text = "Execute";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // statusButton
            // 
            this.statusButton.Location = new System.Drawing.Point(456, 70);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(75, 24);
            this.statusButton.TabIndex = 7;
            this.statusButton.Text = "Refresh";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // playerBox
            // 
            this.playerBox.FormattingEnabled = true;
            this.playerBox.Items.AddRange(new object[] {
            "Name",
            "Ping"});
            this.playerBox.Location = new System.Drawing.Point(452, 153);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(287, 277);
            this.playerBox.TabIndex = 8;
            // 
            // kickButton
            // 
            this.kickButton.Location = new System.Drawing.Point(456, 118);
            this.kickButton.Name = "kickButton";
            this.kickButton.Size = new System.Drawing.Size(75, 23);
            this.kickButton.TabIndex = 9;
            this.kickButton.Text = "Kick";
            this.kickButton.UseCompatibleTextRendering = true;
            this.kickButton.UseVisualStyleBackColor = true;
            this.kickButton.Click += new System.EventHandler(this.kickButton_Click);
            // 
            // banButton
            // 
            this.banButton.Location = new System.Drawing.Point(554, 118);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(75, 23);
            this.banButton.TabIndex = 10;
            this.banButton.Text = "Ban";
            this.banButton.UseVisualStyleBackColor = true;
            this.banButton.Click += new System.EventHandler(this.banButton_Click);
            // 
            // playerCount
            // 
            this.playerCount.AutoSize = true;
            this.playerCount.Location = new System.Drawing.Point(645, 123);
            this.playerCount.Name = "playerCount";
            this.playerCount.Size = new System.Drawing.Size(53, 13);
            this.playerCount.TabIndex = 11;
            this.playerCount.Text = "Players: 0";
            // 
            // serverTabControl
            // 
            this.serverTabControl.Controls.Add(this.serverTab);
            this.serverTabControl.Controls.Add(this.messageRotationTab);
            this.serverTabControl.Controls.Add(this.settingsTab);
            this.serverTabControl.Location = new System.Drawing.Point(0, 3);
            this.serverTabControl.Name = "serverTabControl";
            this.serverTabControl.SelectedIndex = 0;
            this.serverTabControl.Size = new System.Drawing.Size(780, 468);
            this.serverTabControl.TabIndex = 12;
            // 
            // serverTab
            // 
            this.serverTab.Controls.Add(this.button4);
            this.serverTab.Controls.Add(this.label24);
            this.serverTab.Controls.Add(this.autorefreshTime);
            this.serverTab.Controls.Add(this.ipAdress);
            this.serverTab.Controls.Add(this.playerCount);
            this.serverTab.Controls.Add(this.passWord);
            this.serverTab.Controls.Add(this.banButton);
            this.serverTab.Controls.Add(this.portNum);
            this.serverTab.Controls.Add(this.kickButton);
            this.serverTab.Controls.Add(this.connect);
            this.serverTab.Controls.Add(this.playerBox);
            this.serverTab.Controls.Add(this.console);
            this.serverTab.Controls.Add(this.statusButton);
            this.serverTab.Controls.Add(this.command);
            this.serverTab.Controls.Add(this.execute);
            this.serverTab.Location = new System.Drawing.Point(4, 22);
            this.serverTab.Name = "serverTab";
            this.serverTab.Padding = new System.Windows.Forms.Padding(3);
            this.serverTab.Size = new System.Drawing.Size(772, 442);
            this.serverTab.TabIndex = 0;
            this.serverTab.Text = "Server";
            this.serverTab.UseVisualStyleBackColor = true;
            // 
            // messageRotationTab
            // 
            this.messageRotationTab.Location = new System.Drawing.Point(4, 22);
            this.messageRotationTab.Name = "messageRotationTab";
            this.messageRotationTab.Padding = new System.Windows.Forms.Padding(3);
            this.messageRotationTab.Size = new System.Drawing.Size(772, 442);
            this.messageRotationTab.TabIndex = 1;
            this.messageRotationTab.Text = "Message Rotation";
            this.messageRotationTab.UseVisualStyleBackColor = true;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.button3);
            this.settingsTab.Controls.Add(this.button2);
            this.settingsTab.Controls.Add(this.button1);
            this.settingsTab.Controls.Add(this.g_messageOfTheDay);
            this.settingsTab.Controls.Add(this.g_serverImageUrl);
            this.settingsTab.Controls.Add(this.sv_servername);
            this.settingsTab.Controls.Add(this.ban_timeout);
            this.settingsTab.Controls.Add(this.net_reserved_slot_system);
            this.settingsTab.Controls.Add(this.label23);
            this.settingsTab.Controls.Add(this.label22);
            this.settingsTab.Controls.Add(this.label21);
            this.settingsTab.Controls.Add(this.label20);
            this.settingsTab.Controls.Add(this.label19);
            this.settingsTab.Controls.Add(this.sv_votingTimeout);
            this.settingsTab.Controls.Add(this.sv_votingEnable);
            this.settingsTab.Controls.Add(this.sv_votingBanTime);
            this.settingsTab.Controls.Add(this.label18);
            this.settingsTab.Controls.Add(this.label17);
            this.settingsTab.Controls.Add(this.label16);
            this.settingsTab.Controls.Add(this.sv_votingRatio);
            this.settingsTab.Controls.Add(this.label15);
            this.settingsTab.Controls.Add(this.g_switchTeamUnbalancedWarningTimer);
            this.settingsTab.Controls.Add(this.sv_password);
            this.settingsTab.Controls.Add(this.sv_votingCooldown);
            this.settingsTab.Controls.Add(this.label14);
            this.settingsTab.Controls.Add(this.label13);
            this.settingsTab.Controls.Add(this.label12);
            this.settingsTab.Controls.Add(this.g_switchTeamUnbalancedWarningDifference);
            this.settingsTab.Controls.Add(this.label11);
            this.settingsTab.Controls.Add(this.g_switchTeamRequiredPlayerDifference);
            this.settingsTab.Controls.Add(this.label10);
            this.settingsTab.Controls.Add(this.label9);
            this.settingsTab.Controls.Add(this.g_switchTeamAllowed);
            this.settingsTab.Controls.Add(this.g_idlekicktime);
            this.settingsTab.Controls.Add(this.label8);
            this.settingsTab.Controls.Add(this.sv_maxPlayers);
            this.settingsTab.Controls.Add(this.label7);
            this.settingsTab.Controls.Add(this.g_pinglimittimer);
            this.settingsTab.Controls.Add(this.label6);
            this.settingsTab.Controls.Add(this.g_pinglimit);
            this.settingsTab.Controls.Add(this.label5);
            this.settingsTab.Controls.Add(this.g_gameRules_startTimerLength);
            this.settingsTab.Controls.Add(this.label4);
            this.settingsTab.Controls.Add(this.gl_time);
            this.settingsTab.Controls.Add(this.label3);
            this.settingsTab.Controls.Add(this.gl_initialTime);
            this.settingsTab.Controls.Add(this.g_autoAssignTeams);
            this.settingsTab.Controls.Add(this.label2);
            this.settingsTab.Controls.Add(this.label1);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(772, 442);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(375, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "Send to server";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 49;
            this.button2.Text = "Save to file";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Load from server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // g_messageOfTheDay
            // 
            this.g_messageOfTheDay.Location = new System.Drawing.Point(612, 133);
            this.g_messageOfTheDay.Name = "g_messageOfTheDay";
            this.g_messageOfTheDay.Size = new System.Drawing.Size(100, 20);
            this.g_messageOfTheDay.TabIndex = 47;
            // 
            // g_serverImageUrl
            // 
            this.g_serverImageUrl.Location = new System.Drawing.Point(612, 166);
            this.g_serverImageUrl.Name = "g_serverImageUrl";
            this.g_serverImageUrl.Size = new System.Drawing.Size(100, 20);
            this.g_serverImageUrl.TabIndex = 46;
            // 
            // sv_servername
            // 
            this.sv_servername.Location = new System.Drawing.Point(612, 197);
            this.sv_servername.Name = "sv_servername";
            this.sv_servername.Size = new System.Drawing.Size(100, 20);
            this.sv_servername.TabIndex = 45;
            // 
            // ban_timeout
            // 
            this.ban_timeout.Location = new System.Drawing.Point(612, 227);
            this.ban_timeout.Name = "ban_timeout";
            this.ban_timeout.Size = new System.Drawing.Size(100, 20);
            this.ban_timeout.TabIndex = 44;
            // 
            // net_reserved_slot_system
            // 
            this.net_reserved_slot_system.Location = new System.Drawing.Point(612, 262);
            this.net_reserved_slot_system.Name = "net_reserved_slot_system";
            this.net_reserved_slot_system.Size = new System.Drawing.Size(100, 20);
            this.net_reserved_slot_system.TabIndex = 43;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(372, 136);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(126, 13);
            this.label23.TabIndex = 42;
            this.label23.Text = "Message of the day (text)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(372, 169);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(125, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "Server image URL (URL)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(372, 265);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "Enable reserved slots (0/1)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(372, 230);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "Ban length (Seconds, 0=permanent)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(372, 200);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Servername (Text)";
            // 
            // sv_votingTimeout
            // 
            this.sv_votingTimeout.Location = new System.Drawing.Point(612, 43);
            this.sv_votingTimeout.Name = "sv_votingTimeout";
            this.sv_votingTimeout.Size = new System.Drawing.Size(100, 20);
            this.sv_votingTimeout.TabIndex = 37;
            // 
            // sv_votingEnable
            // 
            this.sv_votingEnable.Location = new System.Drawing.Point(612, 71);
            this.sv_votingEnable.Name = "sv_votingEnable";
            this.sv_votingEnable.Size = new System.Drawing.Size(100, 20);
            this.sv_votingEnable.TabIndex = 36;
            // 
            // sv_votingBanTime
            // 
            this.sv_votingBanTime.Location = new System.Drawing.Point(612, 103);
            this.sv_votingBanTime.Name = "sv_votingBanTime";
            this.sv_votingBanTime.Size = new System.Drawing.Size(100, 20);
            this.sv_votingBanTime.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(372, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Voteban Time (Seconds)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(372, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Enable voting (1/0)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(372, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Time for a vote (Seconds?)";
            // 
            // sv_votingRatio
            // 
            this.sv_votingRatio.Location = new System.Drawing.Point(612, 15);
            this.sv_votingRatio.Name = "sv_votingRatio";
            this.sv_votingRatio.Size = new System.Drawing.Size(100, 20);
            this.sv_votingRatio.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(372, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Ratio of accepted votes (decimal)";
            // 
            // g_switchTeamUnbalancedWarningTimer
            // 
            this.g_switchTeamUnbalancedWarningTimer.Location = new System.Drawing.Point(239, 357);
            this.g_switchTeamUnbalancedWarningTimer.Name = "g_switchTeamUnbalancedWarningTimer";
            this.g_switchTeamUnbalancedWarningTimer.Size = new System.Drawing.Size(100, 20);
            this.g_switchTeamUnbalancedWarningTimer.TabIndex = 28;
            // 
            // sv_password
            // 
            this.sv_password.Location = new System.Drawing.Point(239, 386);
            this.sv_password.Name = "sv_password";
            this.sv_password.Size = new System.Drawing.Size(100, 20);
            this.sv_password.TabIndex = 27;
            // 
            // sv_votingCooldown
            // 
            this.sv_votingCooldown.Location = new System.Drawing.Point(239, 414);
            this.sv_votingCooldown.Name = "sv_votingCooldown";
            this.sv_votingCooldown.Size = new System.Drawing.Size(100, 20);
            this.sv_votingCooldown.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 417);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Time between vote initiations";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Rcon Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Time between unbalanced warnings (?)";
            // 
            // g_switchTeamUnbalancedWarningDifference
            // 
            this.g_switchTeamUnbalancedWarningDifference.Location = new System.Drawing.Point(239, 326);
            this.g_switchTeamUnbalancedWarningDifference.Name = "g_switchTeamUnbalancedWarningDifference";
            this.g_switchTeamUnbalancedWarningDifference.Size = new System.Drawing.Size(100, 20);
            this.g_switchTeamUnbalancedWarningDifference.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Threshold playerdifference warning (players)";
            // 
            // g_switchTeamRequiredPlayerDifference
            // 
            this.g_switchTeamRequiredPlayerDifference.Location = new System.Drawing.Point(239, 293);
            this.g_switchTeamRequiredPlayerDifference.Name = "g_switchTeamRequiredPlayerDifference";
            this.g_switchTeamRequiredPlayerDifference.Size = new System.Drawing.Size(100, 20);
            this.g_switchTeamRequiredPlayerDifference.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Playerdifference unbalanced teams (players)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Allow unbalanced team switching (0/1)";
            // 
            // g_switchTeamAllowed
            // 
            this.g_switchTeamAllowed.Location = new System.Drawing.Point(239, 262);
            this.g_switchTeamAllowed.Name = "g_switchTeamAllowed";
            this.g_switchTeamAllowed.Size = new System.Drawing.Size(100, 20);
            this.g_switchTeamAllowed.TabIndex = 16;
            // 
            // g_idlekicktime
            // 
            this.g_idlekicktime.Location = new System.Drawing.Point(239, 230);
            this.g_idlekicktime.Name = "g_idlekicktime";
            this.g_idlekicktime.Size = new System.Drawing.Size(100, 20);
            this.g_idlekicktime.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Idle kick time (Seconds)";
            // 
            // sv_maxPlayers
            // 
            this.sv_maxPlayers.Location = new System.Drawing.Point(239, 197);
            this.sv_maxPlayers.Name = "sv_maxPlayers";
            this.sv_maxPlayers.Size = new System.Drawing.Size(100, 20);
            this.sv_maxPlayers.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Maximum players (number of players)";
            // 
            // g_pinglimittimer
            // 
            this.g_pinglimittimer.Location = new System.Drawing.Point(239, 166);
            this.g_pinglimittimer.Name = "g_pinglimittimer";
            this.g_pinglimittimer.Size = new System.Drawing.Size(100, 20);
            this.g_pinglimittimer.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pinglimit exceed time (Seconds)";
            // 
            // g_pinglimit
            // 
            this.g_pinglimit.Location = new System.Drawing.Point(239, 133);
            this.g_pinglimit.Name = "g_pinglimit";
            this.g_pinglimit.Size = new System.Drawing.Size(100, 20);
            this.g_pinglimit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pinglimit (ms, 0=disabled)";
            // 
            // g_gameRules_startTimerLength
            // 
            this.g_gameRules_startTimerLength.Location = new System.Drawing.Point(239, 103);
            this.g_gameRules_startTimerLength.Name = "g_gameRules_startTimerLength";
            this.g_gameRules_startTimerLength.Size = new System.Drawing.Size(100, 20);
            this.g_gameRules_startTimerLength.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Game start time (Seconds)";
            // 
            // gl_time
            // 
            this.gl_time.Location = new System.Drawing.Point(239, 74);
            this.gl_time.Name = "gl_time";
            this.gl_time.Size = new System.Drawing.Size(100, 20);
            this.gl_time.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time between game (Seconds)";
            // 
            // gl_initialTime
            // 
            this.gl_initialTime.Location = new System.Drawing.Point(239, 43);
            this.gl_initialTime.Name = "gl_initialTime";
            this.gl_initialTime.Size = new System.Drawing.Size(100, 20);
            this.gl_initialTime.TabIndex = 3;
            // 
            // g_autoAssignTeams
            // 
            this.g_autoAssignTeams.Location = new System.Drawing.Point(239, 15);
            this.g_autoAssignTeams.Name = "g_autoAssignTeams";
            this.g_autoAssignTeams.Size = new System.Drawing.Size(100, 20);
            this.g_autoAssignTeams.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time before loading into game (seconds)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto assign teams (0/1)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(453, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "Refresh time (Seconds)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(675, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Apply";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // autorefreshTime
            // 
            this.autorefreshTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crysis3Rcon.Properties.Settings.Default, "Refreshtime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.autorefreshTime.Location = new System.Drawing.Point(576, 18);
            this.autorefreshTime.Name = "autorefreshTime";
            this.autorefreshTime.Size = new System.Drawing.Size(75, 20);
            this.autorefreshTime.TabIndex = 12;
            this.autorefreshTime.Text = global::Crysis3Rcon.Properties.Settings.Default.Refreshtime;
            // 
            // ipAdress
            // 
            this.ipAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crysis3Rcon.Properties.Settings.Default, "Server", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ipAdress.Location = new System.Drawing.Point(3, 18);
            this.ipAdress.Name = "ipAdress";
            this.ipAdress.Size = new System.Drawing.Size(147, 20);
            this.ipAdress.TabIndex = 0;
            this.ipAdress.Text = global::Crysis3Rcon.Properties.Settings.Default.Server;
            // 
            // passWord
            // 
            this.passWord.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crysis3Rcon.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.passWord.Location = new System.Drawing.Point(248, 18);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(74, 20);
            this.passWord.TabIndex = 2;
            this.passWord.Text = global::Crysis3Rcon.Properties.Settings.Default.Password;
            // 
            // portNum
            // 
            this.portNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crysis3Rcon.Properties.Settings.Default, "Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portNum.Location = new System.Drawing.Point(156, 18);
            this.portNum.Name = "portNum";
            this.portNum.Size = new System.Drawing.Size(86, 20);
            this.portNum.TabIndex = 1;
            this.portNum.Text = global::Crysis3Rcon.Properties.Settings.Default.Port;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 474);
            this.Controls.Add(this.serverTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crysis 3 RCON";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.serverTabControl.ResumeLayout(false);
            this.serverTab.ResumeLayout(false);
            this.serverTab.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ipAdress;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.TextBox portNum;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.TextBox command;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.ListBox playerBox;
        private System.Windows.Forms.Button kickButton;
        private System.Windows.Forms.Button banButton;
        private System.Windows.Forms.Label playerCount;
        private System.Windows.Forms.TabControl serverTabControl;
        private System.Windows.Forms.TabPage serverTab;
        private System.Windows.Forms.TabPage messageRotationTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox g_messageOfTheDay;
        private System.Windows.Forms.TextBox g_serverImageUrl;
        private System.Windows.Forms.TextBox sv_servername;
        private System.Windows.Forms.TextBox ban_timeout;
        private System.Windows.Forms.TextBox net_reserved_slot_system;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox sv_votingTimeout;
        private System.Windows.Forms.TextBox sv_votingEnable;
        private System.Windows.Forms.TextBox sv_votingBanTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox sv_votingRatio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox g_switchTeamUnbalancedWarningTimer;
        private System.Windows.Forms.TextBox sv_password;
        private System.Windows.Forms.TextBox sv_votingCooldown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox g_switchTeamUnbalancedWarningDifference;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox g_switchTeamRequiredPlayerDifference;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox g_switchTeamAllowed;
        private System.Windows.Forms.TextBox g_idlekicktime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sv_maxPlayers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox g_pinglimittimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox g_pinglimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox g_gameRules_startTimerLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gl_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gl_initialTime;
        private System.Windows.Forms.TextBox g_autoAssignTeams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox autorefreshTime;


    }
}

