namespace HMI3_Ex1
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
            this.button_LEDOn = new System.Windows.Forms.Button();
            this.button_LEDOff = new System.Windows.Forms.Button();
            this.button_PWMInc = new System.Windows.Forms.Button();
            this.button_PWMDec = new System.Windows.Forms.Button();
            this.button_Digital = new System.Windows.Forms.Button();
            this.button_Analog = new System.Windows.Forms.Button();
            this.label_Digital = new System.Windows.Forms.Label();
            this.label_Analog = new System.Windows.Forms.Label();
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
            this.button_LEDOff.Location = new System.Drawing.Point(123, 13);
            this.button_LEDOff.Name = "button_LEDOff";
            this.button_LEDOff.Size = new System.Drawing.Size(91, 23);
            this.button_LEDOff.TabIndex = 1;
            this.button_LEDOff.Text = "Turn LED OFF";
            this.button_LEDOff.UseVisualStyleBackColor = true;
            this.button_LEDOff.Click += new System.EventHandler(this.button_LEDOff_Click);
            // 
            // button_PWMInc
            // 
            this.button_PWMInc.Location = new System.Drawing.Point(12, 54);
            this.button_PWMInc.Name = "button_PWMInc";
            this.button_PWMInc.Size = new System.Drawing.Size(94, 23);
            this.button_PWMInc.TabIndex = 2;
            this.button_PWMInc.Text = "PWM++";
            this.button_PWMInc.UseVisualStyleBackColor = true;
            this.button_PWMInc.Click += new System.EventHandler(this.button_PWMInc_Click);
            // 
            // button_PWMDec
            // 
            this.button_PWMDec.Location = new System.Drawing.Point(123, 54);
            this.button_PWMDec.Name = "button_PWMDec";
            this.button_PWMDec.Size = new System.Drawing.Size(91, 23);
            this.button_PWMDec.TabIndex = 3;
            this.button_PWMDec.Text = "PWM--";
            this.button_PWMDec.UseVisualStyleBackColor = true;
            this.button_PWMDec.Click += new System.EventHandler(this.button_PWMDec_Click);
            // 
            // button_Digital
            // 
            this.button_Digital.Location = new System.Drawing.Point(13, 98);
            this.button_Digital.Name = "button_Digital";
            this.button_Digital.Size = new System.Drawing.Size(93, 23);
            this.button_Digital.TabIndex = 4;
            this.button_Digital.Text = "Read Digital";
            this.button_Digital.UseVisualStyleBackColor = true;
            this.button_Digital.Click += new System.EventHandler(this.button_Digital_Click);
            // 
            // button_Analog
            // 
            this.button_Analog.Location = new System.Drawing.Point(13, 143);
            this.button_Analog.Name = "button_Analog";
            this.button_Analog.Size = new System.Drawing.Size(93, 23);
            this.button_Analog.TabIndex = 5;
            this.button_Analog.Text = "Read Analog";
            this.button_Analog.UseVisualStyleBackColor = true;
            this.button_Analog.Click += new System.EventHandler(this.button_Analog_Click);
            // 
            // label_Digital
            // 
            this.label_Digital.AutoSize = true;
            this.label_Digital.Location = new System.Drawing.Point(120, 103);
            this.label_Digital.Name = "label_Digital";
            this.label_Digital.Size = new System.Drawing.Size(35, 13);
            this.label_Digital.TabIndex = 6;
            this.label_Digital.Text = "label1";
            // 
            // label_Analog
            // 
            this.label_Analog.AutoSize = true;
            this.label_Analog.Location = new System.Drawing.Point(120, 148);
            this.label_Analog.Name = "label_Analog";
            this.label_Analog.Size = new System.Drawing.Size(35, 13);
            this.label_Analog.TabIndex = 7;
            this.label_Analog.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_Analog);
            this.Controls.Add(this.label_Digital);
            this.Controls.Add(this.button_Analog);
            this.Controls.Add(this.button_Digital);
            this.Controls.Add(this.button_PWMDec);
            this.Controls.Add(this.button_PWMInc);
            this.Controls.Add(this.button_LEDOff);
            this.Controls.Add(this.button_LEDOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LEDOn;
        private System.Windows.Forms.Button button_LEDOff;
        private System.Windows.Forms.Button button_PWMInc;
        private System.Windows.Forms.Button button_PWMDec;
        private System.Windows.Forms.Button button_Digital;
        private System.Windows.Forms.Button button_Analog;
        private System.Windows.Forms.Label label_Digital;
        private System.Windows.Forms.Label label_Analog;
    }
}

