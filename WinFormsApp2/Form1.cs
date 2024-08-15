using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Communication;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SerialTool.Open("COM12", 19200, 8, 1);
            if (SerialTool.IsOpen== true)
            {
                SerialTool.Close();               
            }
            else
            {
                SerialTool.Open("COM12",19200,8,1);
            }
            button_Cnt.Text = SerialTool.IsOpen == true ? "Connected" : "Connect";
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string cmd = comboBox_cmd.Text;
            byte[] byteArray = System.Text.Encoding.Default.GetBytes(cmd);
            List<byte> a = new List<byte>();
            foreach (var item in byteArray)
            {
                a.Add(item);
            }
            if (cmd.Equals(" 1WRITE"))
            {             
                a.Add((byte)int.Parse(textBox_v4.Text));
                a.Add((byte)int.Parse(textBox_v3.Text));
                a.Add((byte)int.Parse(textBox_v2.Text));
                a.Add((byte)int.Parse(textBox_v1.Text));
            }
            SerialTool.Write(a.ToArray());
        }

        private void button_Receive_Click(object sender, EventArgs e)
        {
            if (SerialTool.Received)
            {
                byte[] a = SerialTool.ReceivedBytes;
                string t = System.Text.Encoding.ASCII.GetString(a);
                textBox5.Text = t;
            }
        }
    }
}
