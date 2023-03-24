namespace SysInfo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cpuNameTextBox = new System.Windows.Forms.TextBox();
            this.cpuCoresTextBox = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtMaxClockSpeed = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAdapterRAM = new System.Windows.Forms.TextBox();
            this.txtDriverVersion = new System.Windows.Forms.TextBox();
            this.txtGpuName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpuTemperature = new System.Windows.Forms.TextBox();
            this.timerTemperatureUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cpuNameTextBox
            // 
            this.cpuNameTextBox.Location = new System.Drawing.Point(22, 21);
            this.cpuNameTextBox.Name = "cpuNameTextBox";
            this.cpuNameTextBox.Size = new System.Drawing.Size(269, 23);
            this.cpuNameTextBox.TabIndex = 0;
            // 
            // cpuCoresTextBox
            // 
            this.cpuCoresTextBox.Location = new System.Drawing.Point(22, 50);
            this.cpuCoresTextBox.Name = "cpuCoresTextBox";
            this.cpuCoresTextBox.Size = new System.Drawing.Size(269, 23);
            this.cpuCoresTextBox.TabIndex = 1;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(22, 79);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(269, 23);
            this.txtManufacturer.TabIndex = 2;
            // 
            // txtMaxClockSpeed
            // 
            this.txtMaxClockSpeed.Location = new System.Drawing.Point(22, 108);
            this.txtMaxClockSpeed.Name = "txtMaxClockSpeed";
            this.txtMaxClockSpeed.Size = new System.Drawing.Size(269, 23);
            this.txtMaxClockSpeed.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(22, 137);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(269, 23);
            this.txtDescription.TabIndex = 4;
            // 
            // txtAdapterRAM
            // 
            this.txtAdapterRAM.Location = new System.Drawing.Point(22, 259);
            this.txtAdapterRAM.Name = "txtAdapterRAM";
            this.txtAdapterRAM.Size = new System.Drawing.Size(269, 23);
            this.txtAdapterRAM.TabIndex = 5;
            // 
            // txtDriverVersion
            // 
            this.txtDriverVersion.Location = new System.Drawing.Point(22, 288);
            this.txtDriverVersion.Name = "txtDriverVersion";
            this.txtDriverVersion.Size = new System.Drawing.Size(269, 23);
            this.txtDriverVersion.TabIndex = 6;
            // 
            // txtGpuName
            // 
            this.txtGpuName.Location = new System.Drawing.Point(22, 230);
            this.txtGpuName.Name = "txtGpuName";
            this.txtGpuName.Size = new System.Drawing.Size(269, 23);
            this.txtGpuName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPU Temp";
            // 
            // txtCpuTemperature
            // 
            this.txtCpuTemperature.Location = new System.Drawing.Point(606, 76);
            this.txtCpuTemperature.Name = "txtCpuTemperature";
            this.txtCpuTemperature.Size = new System.Drawing.Size(135, 23);
            this.txtCpuTemperature.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCpuTemperature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGpuName);
            this.Controls.Add(this.txtDriverVersion);
            this.Controls.Add(this.txtAdapterRAM);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtMaxClockSpeed);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.cpuCoresTextBox);
            this.Controls.Add(this.cpuNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox cpuNameTextBox;
        private TextBox cpuCoresTextBox;
        private TextBox txtManufacturer;
        private TextBox txtMaxClockSpeed;
        private TextBox txtDescription;
        private TextBox txtAdapterRAM;
        private TextBox txtDriverVersion;
        private TextBox txtGpuName;
        private Label label1;
        private TextBox txtCpuTemperature;
        private System.Windows.Forms.Timer timerTemperatureUpdate;
    }
}