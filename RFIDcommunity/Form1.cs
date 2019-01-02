using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RFIDcommunity
{
    public partial class Form1 : Form
    {
        string[] ports = SerialPort.GetPortNames();
        private Int32 totalLength = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string port in ports)
            {
                ComportName.Items.Add(port);
            }
        }

        private void _port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(30);
            if (this.serialPort1.BytesToRead > 0)
            {
                if (radAsc.Checked)
                {
                    string data = serialPort1.ReadExisting();
                    BeginInvoke((Action)delegate { CopyPaste(data); });
                }
                else if (radByte.Checked)
                {
                    Byte[] buffer = new Byte[1024];
                    Int32 length = (sender as SerialPort).Read(buffer, 0, buffer.Length);
                    Array.Resize(ref buffer, length);
                    Display d = new Display(DisplayText);
                    this.Invoke(d, new Object[] { buffer });
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (ComportName.SelectedItem != null)
            {
                serialPort1.PortName = ComportName.SelectedItem.ToString();
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                serialPort1.Open();
                serialPort1.DtrEnable = true;
                //true 表示啟用 Data Terminal Ready (DTR)，否則為 false。
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(_port_DataReceived);

                if (serialPort1.IsOpen)
                {
                    btnConnect.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("請選擇連線comport");
            }
        }

        delegate void Display(Byte[] buffer);

        private void DisplayText(Byte[] buffer)
        {
            string antdata;

            antdata = String.Format("{0}{1}", BitConverter.ToString(buffer), Environment.NewLine);

             if (antdata.Length > 200)
             {
                 string[] antdata1 = antdata.Split('-');

                 txtLabel.Text += "通道0:  ";
                 for (int i = 4; i < 11; i++)
                 {
                     txtLabel.Text += antdata1[i] + " ";
                 }
                 txtLabel.Text += "\r\n";

                 txtLabel.Text += "通道1:  ";

                 for (int i = 12; i < 19; i++)
                 {
                     txtLabel.Text += antdata1[i] + " ";
                 }
                 txtLabel.Text += "\r\n";

                 txtLabel.Text += "通道2:  ";

                 for (int i = 20; i < 27; i++)
                 {
                     txtLabel.Text += antdata1[i] + " ";
                 }
                 txtLabel.Text += "\r\n";

                 txtLabel.Text += "通道3:  ";

                 for (int i = 28; i < 35; i++)
                 {
                     txtLabel.Text += antdata1[i] + " ";
                 }
                 txtLabel.Text += "\r\n";

                 txtLabel.Text += "通道4:  ";

                 for (int i = 36; i < 43; i++)
                 {
                     txtLabel.Text += antdata1[i] + " ";
                 }
                 txtLabel.Text += "\r\n";

                 txtLabel.Text += "通道5:  ";

                 for (int i = 44; i < 51; i++)
                 {
                     txtLabel.Text += antdata1[i] + " ";
                 }
                 txtLabel.Text += "\r\n";

                 txtLabel.Text += "通道6:  ";

                 for (int i = 52; i < 59; i++)
                 {
                     txtLabel.Text += antdata1[i] + " ";
                 }
                 txtLabel.Text += "\r\n";

                 txtLabel.Text += "通道7:  ";

                 for (int i = 60; i < 67; i++)
                 {
                     txtLabel.Text += antdata1[i] + " ";
                 }
                 txtLabel.Text += "\r\n";

                 txtLabel.Text += "通道8:  ";

                 for (int i = 68; i < 75; i++)
                 {
                     txtLabel.Text += antdata1[i] + " ";
                 }
                 txtLabel.Text += "\r\n";

                 txtLabel.Text += "通道9:  ";

                 for (int i = 76; i < 83; i++)
                 {
                     txtLabel.Text += antdata1[i] + " ";
                 }
                 txtLabel.Text += "\r\n";

                 txtLabel.Text += "通道10:  ";

                 for (int i = 84; i < 91; i++)
                 {
                     txtLabel.Text += antdata1[i] + " ";
                 }
                 txtLabel.Text += "\r\n";
             }
             else
             {
                 txtLabel.Text += String.Format("{0}{1}", BitConverter.ToString(buffer), Environment.NewLine);
                 totalLength = totalLength + buffer.Length;
             }
            txtLabel.Text += String.Format("{0}{1}", BitConverter.ToString(buffer), Environment.NewLine);
        }

        private void CopyPaste(string data)
        {
            txtLabel.AppendText(data);
        }

        private void btnreadantid_Click(object sender, EventArgs e)
        {
            serialPort1.Write(new byte[] { 0x23, 0xA3, 0x80, 0x2A }, 0, 4);
        }

        private void btnReadVersion_Click(object sender, EventArgs e)
        {  
            serialPort1.Write(new byte[] { 0x23, 0xA2,0x01, 0x80, 0x2A }, 0, 5);
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            serialPort1.Write(new byte[] { 0x23, 0x11, 0x01, 0x33, 0x2A }, 0, 5);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtLabel.Clear();
        }
    }
}
