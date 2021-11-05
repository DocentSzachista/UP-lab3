
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Retrieve = new System.Windows.Forms.Button();
            this.EndConnection = new System.Windows.Forms.Button();
            this.CommandMode = new System.Windows.Forms.Button();
            this.WritingMode = new System.Windows.Forms.Button();
            this.ConnectSerial = new System.Windows.Forms.Button();
            this.connectInfoLabel = new System.Windows.Forms.Label();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.ScreenTextBox = new System.Windows.Forms.RichTextBox();
            this.Break_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(12, 219);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(200, 23);
            this.PortTextBox.TabIndex = 0;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(536, 132);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(117, 23);
            this.Connect.TabIndex = 1;
            this.Connect.Text = "Zacznij połączenie";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numer modemu  z \r\nktórym się łączymy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Retrieve
            // 
            this.Retrieve.Location = new System.Drawing.Point(407, 132);
            this.Retrieve.Name = "Retrieve";
            this.Retrieve.Size = new System.Drawing.Size(123, 23);
            this.Retrieve.TabIndex = 3;
            this.Retrieve.Text = "Odbierz";
            this.Retrieve.UseVisualStyleBackColor = true;
            this.Retrieve.Click += new System.EventHandler(this.button1_Click);
            // 
            // EndConnection
            // 
            this.EndConnection.Enabled = false;
            this.EndConnection.Location = new System.Drawing.Point(407, 74);
            this.EndConnection.Name = "EndConnection";
            this.EndConnection.Size = new System.Drawing.Size(246, 23);
            this.EndConnection.TabIndex = 4;
            this.EndConnection.Text = "Zerwij połączenie i zamknij port";
            this.EndConnection.UseVisualStyleBackColor = true;
            this.EndConnection.Click += new System.EventHandler(this.EndConnection_Click);
            // 
            // CommandMode
            // 
            this.CommandMode.Location = new System.Drawing.Point(407, 103);
            this.CommandMode.Name = "CommandMode";
            this.CommandMode.Size = new System.Drawing.Size(123, 23);
            this.CommandMode.TabIndex = 5;
            this.CommandMode.Text = "Tryb komend";
            this.CommandMode.UseVisualStyleBackColor = true;
            this.CommandMode.Click += new System.EventHandler(this.CommandMode_Click);
            // 
            // WritingMode
            // 
            this.WritingMode.Location = new System.Drawing.Point(536, 103);
            this.WritingMode.Name = "WritingMode";
            this.WritingMode.Size = new System.Drawing.Size(117, 23);
            this.WritingMode.TabIndex = 6;
            this.WritingMode.Text = "Tryb pisania";
            this.WritingMode.UseVisualStyleBackColor = true;
            this.WritingMode.Click += new System.EventHandler(this.WritingMode_Click);
            // 
            // ConnectSerial
            // 
            this.ConnectSerial.Location = new System.Drawing.Point(407, 45);
            this.ConnectSerial.Name = "ConnectSerial";
            this.ConnectSerial.Size = new System.Drawing.Size(246, 23);
            this.ConnectSerial.TabIndex = 7;
            this.ConnectSerial.Text = "Połącz z modemem po porcie szeregowym";
            this.ConnectSerial.UseVisualStyleBackColor = true;
            this.ConnectSerial.Click += new System.EventHandler(this.ConnectSerial_Click);
            // 
            // connectInfoLabel
            // 
            this.connectInfoLabel.AutoSize = true;
            this.connectInfoLabel.Location = new System.Drawing.Point(487, 27);
            this.connectInfoLabel.Name = "connectInfoLabel";
            this.connectInfoLabel.Size = new System.Drawing.Size(83, 15);
            this.connectInfoLabel.TabIndex = 8;
            this.connectInfoLabel.Text = "Nie połączono";
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(12, 248);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(374, 23);
            this.MessageBox.TabIndex = 11;
            this.MessageBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(407, 248);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(246, 23);
            this.SendMessage.TabIndex = 12;
            this.SendMessage.Text = "Wyślij wiadomość";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // ScreenTextBox
            // 
            this.ScreenTextBox.Location = new System.Drawing.Point(23, 45);
            this.ScreenTextBox.Name = "ScreenTextBox";
            this.ScreenTextBox.Size = new System.Drawing.Size(363, 110);
            this.ScreenTextBox.TabIndex = 13;
            this.ScreenTextBox.Text = "";
            // 
            // Break_Button
            // 
            this.Break_Button.Location = new System.Drawing.Point(407, 162);
            this.Break_Button.Name = "Break_Button";
            this.Break_Button.Size = new System.Drawing.Size(246, 42);
            this.Break_Button.TabIndex = 14;
            this.Break_Button.Text = "Zerwij połączenie z modemem (zawiesza interfejs na 5 sekund)";
            this.Break_Button.UseVisualStyleBackColor = true;
            this.Break_Button.Click += new System.EventHandler(this.Break_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 302);
            this.Controls.Add(this.Break_Button);
            this.Controls.Add(this.ScreenTextBox);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.connectInfoLabel);
            this.Controls.Add(this.ConnectSerial);
            this.Controls.Add(this.WritingMode);
            this.Controls.Add(this.CommandMode);
            this.Controls.Add(this.EndConnection);
            this.Controls.Add(this.Retrieve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.PortTextBox);
            this.Name = "Form1";
            this.Text = "Aplikacja modemowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Retrieve;
        private System.Windows.Forms.Button EndConnection;
        private System.Windows.Forms.Button CommandMode;
        private System.Windows.Forms.Button WritingMode;
        private System.Windows.Forms.Button ConnectSerial;
        private System.Windows.Forms.Label connectInfoLabel;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.RichTextBox ScreenTextBox;
        private System.Windows.Forms.Button Break_Button;
    }
}

