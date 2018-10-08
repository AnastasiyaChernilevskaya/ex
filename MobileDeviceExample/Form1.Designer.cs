namespace MobileDeviceExample
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DrviceName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeviceSerial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeviceVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeviceModelNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ActivationState = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DeviceBuildVersion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DeviceBasebandBootloaderVersion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DeviceBasebandVersion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DeviceFirmwareVersion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DeviceId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DeviceName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DevicePhoneNumber = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DeviceProductType = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DeviceSIMStatus = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DeviceWiFiAddress = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.DeviceColor = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lable16 = new System.Windows.Forms.Label();
            this.lbBattery = new System.Windows.Forms.Label();
            this.btnGetDiagnosticsInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(238, 276);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(106, 25);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Refresh status";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipment name";
            // 
            // DrviceName
            // 
            this.DrviceName.AutoSize = true;
            this.DrviceName.Location = new System.Drawing.Point(145, 46);
            this.DrviceName.Name = "DrviceName";
            this.DrviceName.Size = new System.Drawing.Size(35, 13);
            this.DrviceName.TabIndex = 3;
            this.DrviceName.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "serial number";
            // 
            // DeviceSerial
            // 
            this.DeviceSerial.AutoSize = true;
            this.DeviceSerial.Location = new System.Drawing.Point(145, 63);
            this.DeviceSerial.Name = "DeviceSerial";
            this.DeviceSerial.Size = new System.Drawing.Size(67, 13);
            this.DeviceSerial.TabIndex = 5;
            this.DeviceSerial.Text = "DeviceSerial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "iOS version";
            // 
            // DeviceVersion
            // 
            this.DeviceVersion.AutoSize = true;
            this.DeviceVersion.Location = new System.Drawing.Point(145, 79);
            this.DeviceVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.DeviceVersion.Name = "DeviceVersion";
            this.DeviceVersion.Size = new System.Drawing.Size(35, 13);
            this.DeviceVersion.TabIndex = 7;
            this.DeviceVersion.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "model";
            // 
            // DeviceModelNumber
            // 
            this.DeviceModelNumber.AutoSize = true;
            this.DeviceModelNumber.Location = new System.Drawing.Point(145, 95);
            this.DeviceModelNumber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.DeviceModelNumber.Name = "DeviceModelNumber";
            this.DeviceModelNumber.Size = new System.Drawing.Size(35, 13);
            this.DeviceModelNumber.TabIndex = 9;
            this.DeviceModelNumber.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Activation state";
            // 
            // ActivationState
            // 
            this.ActivationState.AutoSize = true;
            this.ActivationState.Location = new System.Drawing.Point(145, 111);
            this.ActivationState.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ActivationState.Name = "ActivationState";
            this.ActivationState.Size = new System.Drawing.Size(35, 13);
            this.ActivationState.TabIndex = 11;
            this.ActivationState.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Internal version";
            // 
            // DeviceBuildVersion
            // 
            this.DeviceBuildVersion.AutoSize = true;
            this.DeviceBuildVersion.Location = new System.Drawing.Point(145, 128);
            this.DeviceBuildVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.DeviceBuildVersion.Name = "DeviceBuildVersion";
            this.DeviceBuildVersion.Size = new System.Drawing.Size(35, 13);
            this.DeviceBuildVersion.TabIndex = 13;
            this.DeviceBuildVersion.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Baseband boot version";
            // 
            // DeviceBasebandBootloaderVersion
            // 
            this.DeviceBasebandBootloaderVersion.AutoSize = true;
            this.DeviceBasebandBootloaderVersion.Location = new System.Drawing.Point(145, 144);
            this.DeviceBasebandBootloaderVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.DeviceBasebandBootloaderVersion.Name = "DeviceBasebandBootloaderVersion";
            this.DeviceBasebandBootloaderVersion.Size = new System.Drawing.Size(35, 13);
            this.DeviceBasebandBootloaderVersion.TabIndex = 15;
            this.DeviceBasebandBootloaderVersion.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Baseband version";
            // 
            // DeviceBasebandVersion
            // 
            this.DeviceBasebandVersion.AutoSize = true;
            this.DeviceBasebandVersion.Location = new System.Drawing.Point(145, 162);
            this.DeviceBasebandVersion.Name = "DeviceBasebandVersion";
            this.DeviceBasebandVersion.Size = new System.Drawing.Size(35, 13);
            this.DeviceBasebandVersion.TabIndex = 17;
            this.DeviceBasebandVersion.Text = "label9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "iBoot version";
            // 
            // DeviceFirmwareVersion
            // 
            this.DeviceFirmwareVersion.AutoSize = true;
            this.DeviceFirmwareVersion.Location = new System.Drawing.Point(145, 178);
            this.DeviceFirmwareVersion.Name = "DeviceFirmwareVersion";
            this.DeviceFirmwareVersion.Size = new System.Drawing.Size(41, 13);
            this.DeviceFirmwareVersion.TabIndex = 19;
            this.DeviceFirmwareVersion.Text = "label10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "UDID";
            // 
            // DeviceId
            // 
            this.DeviceId.AutoSize = true;
            this.DeviceId.Location = new System.Drawing.Point(145, 195);
            this.DeviceId.Name = "DeviceId";
            this.DeviceId.Size = new System.Drawing.Size(41, 13);
            this.DeviceId.TabIndex = 21;
            this.DeviceId.Text = "label11";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Equipment name";
            // 
            // DeviceName
            // 
            this.DeviceName.AutoSize = true;
            this.DeviceName.Location = new System.Drawing.Point(145, 212);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(41, 13);
            this.DeviceName.TabIndex = 23;
            this.DeviceName.Text = "label12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "telephone number";
            // 
            // DevicePhoneNumber
            // 
            this.DevicePhoneNumber.AutoSize = true;
            this.DevicePhoneNumber.Location = new System.Drawing.Point(145, 230);
            this.DevicePhoneNumber.Name = "DevicePhoneNumber";
            this.DevicePhoneNumber.Size = new System.Drawing.Size(41, 13);
            this.DevicePhoneNumber.TabIndex = 25;
            this.DevicePhoneNumber.Text = "label13";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "product version";
            // 
            // DeviceProductType
            // 
            this.DeviceProductType.AutoSize = true;
            this.DeviceProductType.Location = new System.Drawing.Point(145, 247);
            this.DeviceProductType.Name = "DeviceProductType";
            this.DeviceProductType.Size = new System.Drawing.Size(41, 13);
            this.DeviceProductType.TabIndex = 27;
            this.DeviceProductType.Text = "label14";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(285, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "SIM card status";
            // 
            // DeviceSIMStatus
            // 
            this.DeviceSIMStatus.AutoSize = true;
            this.DeviceSIMStatus.Location = new System.Drawing.Point(391, 46);
            this.DeviceSIMStatus.Name = "DeviceSIMStatus";
            this.DeviceSIMStatus.Size = new System.Drawing.Size(41, 13);
            this.DeviceSIMStatus.TabIndex = 29;
            this.DeviceSIMStatus.Text = "label15";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(285, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "WIFI address";
            // 
            // DeviceWiFiAddress
            // 
            this.DeviceWiFiAddress.AutoSize = true;
            this.DeviceWiFiAddress.Location = new System.Drawing.Point(391, 63);
            this.DeviceWiFiAddress.Name = "DeviceWiFiAddress";
            this.DeviceWiFiAddress.Size = new System.Drawing.Size(41, 13);
            this.DeviceWiFiAddress.TabIndex = 31;
            this.DeviceWiFiAddress.Text = "label16";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(32, 276);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(32, 13);
            this.StateLabel.TabIndex = 32;
            this.StateLabel.Text = "State";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 38);
            this.button4.TabIndex = 37;
            this.button4.Text = "Enter recovery mode";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(127, 307);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 38);
            this.button7.TabIndex = 41;
            this.button7.Text = "Leave recovery mode";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // DeviceColor
            // 
            this.DeviceColor.AutoSize = true;
            this.DeviceColor.Location = new System.Drawing.Point(391, 79);
            this.DeviceColor.Name = "DeviceColor";
            this.DeviceColor.Size = new System.Drawing.Size(41, 13);
            this.DeviceColor.TabIndex = 44;
            this.DeviceColor.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(285, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "colour";
            // 
            // lable16
            // 
            this.lable16.AutoSize = true;
            this.lable16.Location = new System.Drawing.Point(285, 95);
            this.lable16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable16.Name = "lable16";
            this.lable16.Size = new System.Drawing.Size(40, 13);
            this.lable16.TabIndex = 45;
            this.lable16.Text = "Battery";
            // 
            // lbBattery
            // 
            this.lbBattery.AutoSize = true;
            this.lbBattery.Location = new System.Drawing.Point(391, 95);
            this.lbBattery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBattery.Name = "lbBattery";
            this.lbBattery.Size = new System.Drawing.Size(41, 13);
            this.lbBattery.TabIndex = 46;
            this.lbBattery.Text = "label16";
            // 
            // btnGetDiagnosticsInfo
            // 
            this.btnGetDiagnosticsInfo.Location = new System.Drawing.Point(238, 307);
            this.btnGetDiagnosticsInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetDiagnosticsInfo.Name = "btnGetDiagnosticsInfo";
            this.btnGetDiagnosticsInfo.Size = new System.Drawing.Size(106, 38);
            this.btnGetDiagnosticsInfo.TabIndex = 47;
            this.btnGetDiagnosticsInfo.Text = "Diagnostic information";
            this.btnGetDiagnosticsInfo.UseVisualStyleBackColor = true;
            this.btnGetDiagnosticsInfo.Click += new System.EventHandler(this.btnGetDiagnosticsInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 352);
            this.Controls.Add(this.btnGetDiagnosticsInfo);
            this.Controls.Add(this.lbBattery);
            this.Controls.Add(this.lable16);
            this.Controls.Add(this.DeviceColor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.DeviceWiFiAddress);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DeviceSIMStatus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DeviceProductType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DevicePhoneNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DeviceName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DeviceId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeviceFirmwareVersion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DeviceBasebandVersion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeviceBasebandBootloaderVersion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeviceBuildVersion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ActivationState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeviceModelNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeviceVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeviceSerial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DrviceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DrviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DeviceSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DeviceVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DeviceModelNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ActivationState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DeviceBuildVersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DeviceBasebandBootloaderVersion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label DeviceBasebandVersion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label DeviceFirmwareVersion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DeviceId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DeviceName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label DevicePhoneNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label DeviceProductType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label DeviceSIMStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label DeviceWiFiAddress;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label DeviceColor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lable16;
        private System.Windows.Forms.Label lbBattery;
        private System.Windows.Forms.Button btnGetDiagnosticsInfo;
    }
}

