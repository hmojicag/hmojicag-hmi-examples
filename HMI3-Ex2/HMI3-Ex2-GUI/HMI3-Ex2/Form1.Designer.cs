namespace HMI3_Ex2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_LEDOn = new System.Windows.Forms.Button();
            this.button_LEDOff = new System.Windows.Forms.Button();
            this.button_PWMInc = new System.Windows.Forms.Button();
            this.button_PWMDec = new System.Windows.Forms.Button();
            this.button_Analog_Start = new System.Windows.Forms.Button();
            this.button_Analog_Stop = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LEDOn
            // 
            this.button_LEDOn.AutoSize = true;
            this.button_LEDOn.Location = new System.Drawing.Point(13, 13);
            this.button_LEDOn.Name = "button_LEDOn";
            this.button_LEDOn.Size = new System.Drawing.Size(93, 23);
            this.button_LEDOn.TabIndex = 0;
            this.button_LEDOn.Text = "Turn LED ON";
            this.button_LEDOn.UseVisualStyleBackColor = true;
            this.button_LEDOn.Click += new System.EventHandler(this.button_LEDOn_Click);
            // 
            // button_LEDOff
            // 
            this.button_LEDOff.Location = new System.Drawing.Point(112, 12);
            this.button_LEDOff.Name = "button_LEDOff";
            this.button_LEDOff.Size = new System.Drawing.Size(91, 23);
            this.button_LEDOff.TabIndex = 1;
            this.button_LEDOff.Text = "Turn LED OFF";
            this.button_LEDOff.UseVisualStyleBackColor = true;
            this.button_LEDOff.Click += new System.EventHandler(this.button_LEDOff_Click);
            // 
            // button_PWMInc
            // 
            this.button_PWMInc.Location = new System.Drawing.Point(209, 12);
            this.button_PWMInc.Name = "button_PWMInc";
            this.button_PWMInc.Size = new System.Drawing.Size(94, 23);
            this.button_PWMInc.TabIndex = 2;
            this.button_PWMInc.Text = "PWM++";
            this.button_PWMInc.UseVisualStyleBackColor = true;
            this.button_PWMInc.Click += new System.EventHandler(this.button_PWMInc_Click);
            // 
            // button_PWMDec
            // 
            this.button_PWMDec.Location = new System.Drawing.Point(309, 12);
            this.button_PWMDec.Name = "button_PWMDec";
            this.button_PWMDec.Size = new System.Drawing.Size(91, 23);
            this.button_PWMDec.TabIndex = 3;
            this.button_PWMDec.Text = "PWM--";
            this.button_PWMDec.UseVisualStyleBackColor = true;
            this.button_PWMDec.Click += new System.EventHandler(this.button_PWMDec_Click);
            // 
            // button_Analog_Start
            // 
            this.button_Analog_Start.Location = new System.Drawing.Point(13, 348);
            this.button_Analog_Start.Name = "button_Analog_Start";
            this.button_Analog_Start.Size = new System.Drawing.Size(93, 23);
            this.button_Analog_Start.TabIndex = 5;
            this.button_Analog_Start.Text = "Start Reading";
            this.button_Analog_Start.UseVisualStyleBackColor = true;
            this.button_Analog_Start.Click += new System.EventHandler(this.button_Analog_Start_Click);
            // 
            // button_Analog_Stop
            // 
            this.button_Analog_Stop.Location = new System.Drawing.Point(112, 348);
            this.button_Analog_Stop.Name = "button_Analog_Stop";
            this.button_Analog_Stop.Size = new System.Drawing.Size(91, 23);
            this.button_Analog_Stop.TabIndex = 8;
            this.button_Analog_Stop.Text = "Stop Reading";
            this.button_Analog_Stop.UseVisualStyleBackColor = true;
            this.button_Analog_Stop.Click += new System.EventHandler(this.button_Analog_Stop_Click);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 42);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(525, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 384);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_Analog_Stop);
            this.Controls.Add(this.button_Analog_Start);
            this.Controls.Add(this.button_PWMDec);
            this.Controls.Add(this.button_PWMInc);
            this.Controls.Add(this.button_LEDOff);
            this.Controls.Add(this.button_LEDOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LEDOn;
        private System.Windows.Forms.Button button_LEDOff;
        private System.Windows.Forms.Button button_PWMInc;
        private System.Windows.Forms.Button button_PWMDec;
        private System.Windows.Forms.Button button_Analog_Start;
        private System.Windows.Forms.Button button_Analog_Stop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

