using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Generic;

namespace HMI4_Ex2_GUI {
    public partial class Form1 : Form {
        private Queue<CVPair> dataQueue;
        private string incomeBuffer;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            comboBox1.Items.Clear();
            //Add a default Message to the combo box
            comboBox1.Items.Add("Select a Serial Port");
            //Fill the ComboBox with the names of the Serial Ports
            string[] availableSerialPorts = SerialPort.GetPortNames();
            foreach(string portName in availableSerialPorts) {
                comboBox1.Items.Add(portName);
            }
            //Choose the "Select a Serial Port" msg for display
            comboBox1.SelectedIndex = 0;
            //Disable Controls Group Box
            groupBox_controls.Enabled = false;
            //Initialize Income data Queue
            dataQueue = new Queue<CVPair>();
            incomeBuffer = string.Empty;
        }

        private void trackBar_pwm_ValueChanged(object sender, EventArgs e) {
            //Send command to Set PWM to trackbar value
            SendData(2, trackBar_pwm.Value);
        }

        private void button_connect_Click(object sender, EventArgs e) {
            if(comboBox1.SelectedIndex > 0) {
                //A valid Serial Port has been selected
                serialPort1.BaudRate = 115200;
                serialPort1.PortName = comboBox1.SelectedItem.ToString();
                try {
                    serialPort1.Open();
                } catch (Exception ex) {
                    timer1.Stop();
                    Console.WriteLine(ex);
                    MessageBox.Show("Error connection to port: "
                        + serialPort1.PortName);
                    this.Close();
                }
                //enable the timer
                timer1.Enabled = true;
                timer1.Start();
                //Swap Group Box
                groupBox_connection.Enabled = false;
                groupBox_controls.Enabled = true;
            }
        }

        private void checkBox_LED_CheckedChanged(object sender, EventArgs e) {
            if(checkBox_LED.Checked) {
                SendData(1, 1);//Send LED command ON
            } else {
                SendData(1, 0);//Send LED command OFF
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            bool dataSent;
            dataSent = SendData(3);//Send Read Digital command
            dataSent = dataSent | SendData(4);//Send Read Analog command

            if(!dataSent) {
                //Error sending data, stop Tick
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("Error sending data to the Arduino");
                this.Close();
            }
            ParseBuffer();
            RefreshGUI();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            timer1.Stop();
            timer1.Enabled = false;
            serialPort1.Close();
        }

        private void ParseBuffer() {
            //This is the tricky code that stores all data received
            //parses and stores it in a List of command value pairs
            try {
                if (serialPort1.IsOpen) {
                    //Read everything the Arduino has sent so far
                    incomeBuffer += serialPort1.ReadExisting();
                }
                //Split string into c-v pairs
                //For example: "digital-HIGH&analog-512&led-HIGH&"
                //will be split in { "digital-HIGH", "analog-512", "led-HIGH", ""}
                string[] cvPairs = incomeBuffer.Split('&');
                incomeBuffer = cvPairs[cvPairs.Length - 1];
                for (int i = 0; i < (cvPairs.Length-1); i++) {
                    string[] cvPair = cvPairs[i].Split('-');
                    if(cvPair.Length == 2) {
                        //If the pair has not exactly 2 elements
                        //a command and a value, discard it
                        CVPair pair = new CVPair();
                        pair.Command = cvPair[0];
                        pair.Value = cvPair[1];
                        dataQueue.Enqueue(pair);
                        Console.WriteLine("Command Enqued: " + cvPairs[i]);
                    } else {
                        Console.WriteLine("Command Discarded: " + cvPairs[i]);
                    }
                }
            } catch(Exception ex) {
                timer1.Stop();
                timer1.Enabled = false;
                Console.WriteLine(ex);
                MessageBox.Show("Error reading data from the Arduino");
                this.Close();
            }
        }

        private void RefreshGUI() {
            foreach(CVPair pair in dataQueue) {
                switch(pair.Command) {
                    case "led":
                        label_LED.Text = "LED Status: " + pair.Value;
                        break;
                    case "pwm":
                        label_PWM.Text = "PWM Val: " + pair.Value;
                        break;
                    case "digital":
                        label_Digital.Text = "Push Button Status: " + pair.Value;
                        break;
                    case "analog":
                        //Convert to Double the ADC value
                        double adcVal = Convert.ToDouble(pair.Value);
                        //The ADC maps the 0 to 5v in 10bits (0 to 1023)
                        double volts = adcVal * 5.0 / 1023.0;
                        label_Analog.Text = "Voltage: " + volts.ToString("##.##") + "V";
                        break;
                    default:
                        Console.WriteLine("Not a recognized response command: " + pair.Command);
                        break;
                }
            }
        }

        private bool SendData(int command) {
            return SendData(command, 0);
        }

        private bool SendData(int command, int value) {
            bool allOk = false;
            if(serialPort1.IsOpen) {
                try {
                    string request = "&" + command + "-" + value + "&";
                    serialPort1.Write(request);
                    Console.WriteLine("Request sent: " + request);
                    allOk = true;
                } catch(Exception ex) {
                    Console.WriteLine(ex);
                }
            }

            return allOk;
        }

        private class CVPair {
            public string Command { get; set; }
            public string Value { get; set; }
        }
    }
}
