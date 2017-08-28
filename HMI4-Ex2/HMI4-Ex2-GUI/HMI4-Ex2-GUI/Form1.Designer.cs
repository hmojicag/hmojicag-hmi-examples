namespace HMI4_Ex2_GUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.checkBox_LED = new System.Windows.Forms.CheckBox();
            this.label_LED = new System.Windows.Forms.Label();
            this.label_PWM = new System.Windows.Forms.Label();
            this.label_Digital = new System.Windows.Forms.Label();
            this.label_Analog = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_connection = new System.Windows.Forms.GroupBox();
            this.groupBox_controls = new System.Windows.Forms.GroupBox();
            this.trackBar_pwm = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_connection.SuspendLayout();
            this.groupBox_controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_pwm)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_LED
            // 
            this.checkBox_LED.AutoSize = true;
            this.checkBox_LED.Location = new System.Drawing.Point(6, 19);
            this.checkBox_LED.Name = "checkBox_LED";
            this.checkBox_LED.Size = new System.Drawing.Size(47, 17);
            this.checkBox_LED.TabIndex = 0;
            this.checkBox_LED.Text = "LED";
            this.checkBox_LED.UseVisualStyleBackColor = true;
            this.checkBox_LED.CheckedChanged += new System.EventHandler(this.checkBox_LED_CheckedChanged);
            // 
            // label_LED
            // 
            this.label_LED.AutoSize = true;
            this.label_LED.Location = new System.Drawing.Point(55, 20);
            this.label_LED.Name = "label_LED";
            this.label_LED.Size = new System.Drawing.Size(61, 13);
            this.label_LED.TabIndex = 1;
            this.label_LED.Text = "LED Status";
            // 
            // label_PWM
            // 
            this.label_PWM.AutoSize = true;
            this.label_PWM.Location = new System.Drawing.Point(7, 90);
            this.label_PWM.Name = "label_PWM";
            this.label_PWM.Size = new System.Drawing.Size(67, 13);
            this.label_PWM.TabIndex = 4;
            this.label_PWM.Text = "PWM Status";
            // 
            // label_Digital
            // 
            this.label_Digital.AutoSize = true;
            this.label_Digital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Digital.Location = new System.Drawing.Point(6, 114);
            this.label_Digital.Name = "label_Digital";
            this.label_Digital.Size = new System.Drawing.Size(171, 20);
            this.label_Digital.TabIndex = 5;
            this.label_Digital.Text = "Push Button Status:";
            // 
            // label_Analog
            // 
            this.label_Analog.AutoSize = true;
            this.label_Analog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Analog.Location = new System.Drawing.Point(6, 143);
            this.label_Analog.Name = "label_Analog";
            this.label_Analog.Size = new System.Drawing.Size(81, 20);
            this.label_Analog.TabIndex = 6;
            this.label_Analog.Text = "Voltage: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(133, 19);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 8;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox_connection
            // 
            this.groupBox_connection.Controls.Add(this.button_connect);
            this.groupBox_connection.Controls.Add(this.comboBox1);
            this.groupBox_connection.Location = new System.Drawing.Point(12, 0);
            this.groupBox_connection.Name = "groupBox_connection";
            this.groupBox_connection.Size = new System.Drawing.Size(247, 55);
            this.groupBox_connection.TabIndex = 10;
            this.groupBox_connection.TabStop = false;
            this.groupBox_connection.Text = "Serial Connection";
            // 
            // groupBox_controls
            // 
            this.groupBox_controls.Controls.Add(this.trackBar_pwm);
            this.groupBox_controls.Controls.Add(this.checkBox_LED);
            this.groupBox_controls.Controls.Add(this.label_LED);
            this.groupBox_controls.Controls.Add(this.label_PWM);
            this.groupBox_controls.Controls.Add(this.label_Analog);
            this.groupBox_controls.Controls.Add(this.label_Digital);
            this.groupBox_controls.Location = new System.Drawing.Point(12, 61);
            this.groupBox_controls.Name = "groupBox_controls";
            this.groupBox_controls.Size = new System.Drawing.Size(247, 168);
            this.groupBox_controls.TabIndex = 11;
            this.groupBox_controls.TabStop = false;
            this.groupBox_controls.Text = "Controls";
            // 
            // trackBar_pwm
            // 
            this.trackBar_pwm.Location = new System.Drawing.Point(0, 42);
            this.trackBar_pwm.Maximum = 200;
            this.trackBar_pwm.Minimum = 130;
            this.trackBar_pwm.Name = "trackBar_pwm";
            this.trackBar_pwm.Size = new System.Drawing.Size(241, 45);
            this.trackBar_pwm.SmallChange = 5;
            this.trackBar_pwm.TabIndex = 7;
            this.trackBar_pwm.TickFrequency = 5;
            this.trackBar_pwm.Value = 130;
            this.trackBar_pwm.ValueChanged += new System.EventHandler(this.trackBar_pwm_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 240);
            this.Controls.Add(this.groupBox_controls);
            this.Controls.Add(this.groupBox_connection);
            this.Name = "Form1";
            this.Text = "Human Machine Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_connection.ResumeLayout(false);
            this.groupBox_controls.ResumeLayout(false);
            this.groupBox_controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_pwm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_LED;
        private System.Windows.Forms.Label label_LED;
        private System.Windows.Forms.Label label_PWM;
        private System.Windows.Forms.Label label_Digital;
        private System.Windows.Forms.Label label_Analog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox_connection;
        private System.Windows.Forms.GroupBox groupBox_controls;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar trackBar_pwm;
    }
}

