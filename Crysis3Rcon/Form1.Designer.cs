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
            this.SuspendLayout();
            // 
            // ipAdress
            // 
            this.ipAdress.Location = new System.Drawing.Point(37, 12);
            this.ipAdress.Name = "ipAdress";
            this.ipAdress.Size = new System.Drawing.Size(155, 20);
            this.ipAdress.TabIndex = 0;
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(290, 12);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(74, 20);
            this.passWord.TabIndex = 1;
            // 
            // portNum
            // 
            this.portNum.Location = new System.Drawing.Point(198, 12);
            this.portNum.Name = "portNum";
            this.portNum.Size = new System.Drawing.Size(86, 20);
            this.portNum.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 369);
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
    }
}

