using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace HMI3_Ex1
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            //Actually creates the Serial Port instance object
            //The Arduino is in COM1 and uses a Baud Rate of 115200bds
            serialPort = new SerialPort("COM3", 115200);
            serialPort.Open();
        }

        private void button_LEDOn_Click(object sender, EventArgs e)
        {
            serialPort.Write("a");
        }

        private void button_LEDOff_Click(object sender, EventArgs e)
        {
            serialPort.Write("b");
        }

        private void button_PWMInc_Click(object sender, EventArgs e)
        {
            serialPort.Write("c");
        }

        private void button_PWMDec_Click(object sender, EventArgs e)
        {
            serialPort.Write("d");
        }

        private void button_Digital_Click(object sender, EventArgs e)
        {
            serialPort.Write("e");
            this.label_Digital.Text = serialPort.ReadLine();
        }

        private void button_Analog_Click(object sender, EventArgs e)
        {
            serialPort.Write("f");
            this.label_Analog.Text = serialPort.ReadLine();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
        }
    }
}
