using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Generic;

namespace HMI3_Ex2 {
    public partial class Form1 : Form {
        private Queue<int> samples;
        public Form1() {
            InitializeComponent();
        }

        private void button_LEDOn_Click(object sender, EventArgs e) {
            serialPort1.Write("a");
        }

        private void button_LEDOff_Click(object sender, EventArgs e) {
            serialPort1.Write("b");
        }

        private void button_PWMInc_Click(object sender, EventArgs e) {
            serialPort1.Write("c");
        }

        private void button_PWMDec_Click(object sender, EventArgs e) {
            serialPort1.Write("d");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            serialPort1.Close();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (serialPort1.IsOpen) {
                //Sends 'f' each 300ms
                serialPort1.Write("f");
                ChartRefresh();
            } else {
                //Something is wrong. Close the application.
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("The Serial Port is not open");
                this.Close();
            }
        }

        private void button_Analog_Start_Click(object sender, EventArgs e) {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button_Analog_Stop_Click(object sender, EventArgs e) {
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            //This method gets called each time data is received over the Serial Port
            SerialPort serialPort = (SerialPort)sender;
            string data = serialPort.ReadLine();
            int analogVal = Convert.ToInt32(data);
            EnqueueSample(analogVal);
        }

        private void Form1_Load(object sender, EventArgs e) {
            samples = new Queue<int>(50);
            serialPort1.Open();
        }

        private void EnqueueSample(int sample) {
            if (samples.Count >= 50) {
                samples.Dequeue();
            }
            samples.Enqueue(sample);
        }

        private void ChartRefresh() {
            chart1.Series[0].Points.Clear();
            foreach(int sample in samples) {
                chart1.Series[0].Points.AddY(sample);
            }
        }
    }
}
