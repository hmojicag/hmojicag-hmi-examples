using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace ListSerialPorts {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            string[] availablePorts = SerialPort.GetPortNames();
            comboBox1.Items.Add("Select a Serial Port");
            foreach(string port in availablePorts) {
                comboBox1.Items.Add(port);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboBox1.SelectedIndex > 0) {
                //If the user selected a valid Serial Port from the list
                string portName = comboBox1.SelectedItem.ToString();
                MessageBox.Show("You selected the Serial Port: " + portName);
            }
        }
    }
}
