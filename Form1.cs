using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private SerialPort port;
        private bool connected;
        public Form1()
        {
            port = new SerialPort();
            InitializeComponent();
        }


   

        private void Send_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.Write("ATD" + PortTextBox.Text + "\r");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                connected = true;
                port.Write("ATA\r");
                ScreenTextBox.Text += "Odbieranie" + Environment.NewLine;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ConnectSerial_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen) {
                port.PortName = "COM1";
                port.Parity = Parity.None;
                port.DataBits = 8;
                port.BaudRate = 9600;
                port.StopBits = StopBits.One;
                port.Handshake = Handshake.RequestToSend;
                port.DataReceived += dataReceived;
                port.RtsEnable = true;
                port.DtrEnable = true;

                port.WriteTimeout = 500;
                port.ReadTimeout = 500;
                try {
                    port.Open();
                    connectInfoLabel.Text = "Połączono";
                    EndConnection.Enabled = true;
                }
                catch(Exception ex)
                {
                    ScreenTextBox.Text += $"Błąd: {ex.Message}\n";
                }

            }
        }

        private void EndConnection_Click(object sender, EventArgs e)
        {
            if(port.IsOpen)
            {
                port.Write("ATH\r");
                port.Close();
                connectInfoLabel.Text = "Nie połączono z modemem";
            }
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            if(port.IsOpen)
            {
                port.Write(MessageBox.Text + "\r");
                ScreenTextBox.Text += "->"+MessageBox.Text+ Environment.NewLine;
            }
        }
        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var data = port.ReadExisting();
            if(data.Contains("CON"))
            {
                connected = true;
                ScreenTextBox.Text += "Połączono z drugim modemem"+Environment.NewLine ;
            }
            ScreenTextBox.Text += "<-"+data  + Environment.NewLine;
        }

        private void CommandMode_Click(object sender, EventArgs e)
        {
            if(port.IsOpen)
            {
                if (connected)
                {
                    ScreenTextBox.Text += "Tryb komend\n";
                    ChangeToCommandLine();
                }
            }
        }
        private void ChangeToCommandLine()
        {
            port.Write("+");
            Thread.Sleep(100);
            port.Write("+");
            Thread.Sleep(100);
            port.Write("+");
            Thread.Sleep(100);
        }
        private void WritingMode_Click(object sender, EventArgs e)
        {
            if(port.IsOpen)
                if(connected)
                {
                    ScreenTextBox.Text += "Tryb pisania\n";
                    port.Write("ATO\r");
                }
        }

        private void Break_Button_Click(object sender, EventArgs e)
        {
            if(port.IsOpen)
            {
                if(connected)
                {
                    ScreenTextBox.Text += "Tryb Zrywanie\n";
                    ChangeToCommandLine();
                    Thread.Sleep(1000);
                    port.Write("ATH\r");
                    Thread.Sleep(5000);
                    port.Write("ATH\r");
                    connected = false;
                }
            }    
        }

        private void ScreenTextBox_TextChanged(object sender, EventArgs e)
        {
            ScreenTextBox.ScrollToCaret();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
