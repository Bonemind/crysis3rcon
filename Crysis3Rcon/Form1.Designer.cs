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
            this.ipAdress = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.portNum = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.TextBox();
            this.command = new System.Windows.Forms.TextBox();
            this.execute = new System.Windows.Forms.Button();
            this.statusButton = new System.Windows.Forms.Button();
            this.playerBox = new System.Windows.Forms.ListBox();
            this.kickButton = new System.Windows.Forms.Button();
            this.banButton = new System.Windows.Forms.Button();
            this.playerCount = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
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
            this.console.Size = new System.Drawing.Size(412, 263);
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
            this.statusButton.Location = new System.Drawing.Point(438, 18);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(178, 24);
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
            this.playerBox.Location = new System.Drawing.Point(438, 85);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(178, 264);
            this.playerBox.TabIndex = 8;
            // 
            // kickButton
            // 
            this.kickButton.Location = new System.Drawing.Point(639, 85);
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
            this.banButton.Location = new System.Drawing.Point(639, 130);
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
            this.playerCount.Location = new System.Drawing.Point(554, 61);
            this.playerCount.Name = "playerCount";
            this.playerCount.Size = new System.Drawing.Size(53, 13);
            this.playerCount.TabIndex = 11;
            this.playerCount.Text = "Players: 0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 381);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ipAdress);
            this.tabPage1.Controls.Add(this.playerCount);
            this.tabPage1.Controls.Add(this.passWord);
            this.tabPage1.Controls.Add(this.banButton);
            this.tabPage1.Controls.Add(this.portNum);
            this.tabPage1.Controls.Add(this.kickButton);
            this.tabPage1.Controls.Add(this.connect);
            this.tabPage1.Controls.Add(this.playerBox);
            this.tabPage1.Controls.Add(this.console);
            this.tabPage1.Controls.Add(this.statusButton);
            this.tabPage1.Controls.Add(this.command);
            this.tabPage1.Controls.Add(this.execute);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Message Rotation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(772, 355);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 391);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crysis 3 RCON";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;


    }
}

