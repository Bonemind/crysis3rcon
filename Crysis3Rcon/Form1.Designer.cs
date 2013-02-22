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
            this.SuspendLayout();
            // 
            // ipAdress
            // 
            this.ipAdress.Location = new System.Drawing.Point(45, 12);
            this.ipAdress.Name = "ipAdress";
            this.ipAdress.Size = new System.Drawing.Size(147, 20);
            this.ipAdress.TabIndex = 0;
            this.ipAdress.Text = "Ip Adress";
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(290, 12);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(74, 20);
            this.passWord.TabIndex = 2;
            this.passWord.Text = "Password";
            // 
            // portNum
            // 
            this.portNum.Location = new System.Drawing.Point(198, 12);
            this.portNum.Name = "portNum";
            this.portNum.Size = new System.Drawing.Size(86, 20);
            this.portNum.TabIndex = 1;
            this.portNum.Text = "Port";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(382, 13);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 3;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(45, 79);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.console.Size = new System.Drawing.Size(412, 263);
            this.console.TabIndex = 4;
            // 
            // command
            // 
            this.command.Location = new System.Drawing.Point(45, 48);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(319, 20);
            this.command.TabIndex = 5;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(382, 50);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(75, 23);
            this.execute.TabIndex = 6;
            this.execute.Text = "Execute";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // statusButton
            // 
            this.statusButton.Location = new System.Drawing.Point(480, 12);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(178, 61);
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
            this.playerBox.Location = new System.Drawing.Point(480, 79);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(178, 264);
            this.playerBox.TabIndex = 8;
            this.playerBox.SelectedIndexChanged += new System.EventHandler(this.playerBox_SelectedIndexChanged);
            // 
            // kickButton
            // 
            this.kickButton.Location = new System.Drawing.Point(681, 79);
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
            this.banButton.Location = new System.Drawing.Point(681, 124);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(75, 23);
            this.banButton.TabIndex = 10;
            this.banButton.Text = "Ban";
            this.banButton.UseVisualStyleBackColor = true;
            this.banButton.Click += new System.EventHandler(this.banButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 369);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.kickButton);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.command);
            this.Controls.Add(this.console);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.portNum);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.ipAdress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

