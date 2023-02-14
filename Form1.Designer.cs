namespace ArduinoLogger
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkSaveCSV = new System.Windows.Forms.CheckBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.chkSendRequest = new System.Windows.Forms.CheckBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCOM = new System.Windows.Forms.TextBox();
            this.txtYMax = new System.Windows.Forms.TextBox();
            this.txtYMin = new System.Windows.Forms.TextBox();
            this.txtMajYGrid = new System.Windows.Forms.TextBox();
            this.txtMinYGrid = new System.Windows.Forms.TextBox();
            this.txtDataWindow = new System.Windows.Forms.TextBox();
            this.chkConvert = new System.Windows.Forms.CheckBox();
            this.txtSerialData = new System.Windows.Forms.TextBox();
            this.radSeconds = new System.Windows.Forms.RadioButton();
            this.radMinutes = new System.Windows.Forms.RadioButton();
            this.txtSampleRate = new System.Windows.Forms.TextBox();
            this.txtVref = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSaveLocation = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(265, 55);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(575, 369);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkSaveCSV
            // 
            this.chkSaveCSV.AutoSize = true;
            this.chkSaveCSV.Location = new System.Drawing.Point(391, 437);
            this.chkSaveCSV.Name = "chkSaveCSV";
            this.chkSaveCSV.Size = new System.Drawing.Size(87, 17);
            this.chkSaveCSV.TabIndex = 2;
            this.chkSaveCSV.Text = "Save to CSV";
            this.chkSaveCSV.UseVisualStyleBackColor = true;
            this.chkSaveCSV.CheckedChanged += new System.EventHandler(this.chkSaveCSV_CheckedChanged);
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(391, 466);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(58, 17);
            this.chkDebug.TabIndex = 3;
            this.chkDebug.Text = "Debug";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(732, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Location = new System.Drawing.Point(221, 109);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(48, 17);
            this.chkFilter.TabIndex = 6;
            this.chkFilter.Text = "Filter";
            this.chkFilter.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(20, 466);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 37);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(20, 419);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(94, 41);
            this.btnLog.TabIndex = 8;
            this.btnLog.Text = "LOG";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // chkSendRequest
            // 
            this.chkSendRequest.AutoSize = true;
            this.chkSendRequest.Location = new System.Drawing.Point(15, 185);
            this.chkSendRequest.Name = "chkSendRequest";
            this.chkSendRequest.Size = new System.Drawing.Size(94, 17);
            this.chkSendRequest.TabIndex = 9;
            this.chkSendRequest.Text = "Send Request";
            this.chkSendRequest.UseVisualStyleBackColor = true;
            this.chkSendRequest.CheckedChanged += new System.EventHandler(this.chkSendRequest_CheckedChanged);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(38, 78);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPort.TabIndex = 11;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnClosePort
            // 
            this.btnClosePort.Location = new System.Drawing.Point(38, 107);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(75, 23);
            this.btnClosePort.TabIndex = 12;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // sp
            // 
            this.sp.PortName = "COM8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Arduino Vref:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sample Rate:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCOM);
            this.groupBox1.Controls.Add(this.btnOpenPort);
            this.groupBox1.Controls.Add(this.btnClosePort);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 149);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "COM Port:";
            // 
            // txtCOM
            // 
            this.txtCOM.Location = new System.Drawing.Point(62, 53);
            this.txtCOM.Name = "txtCOM";
            this.txtCOM.Size = new System.Drawing.Size(26, 20);
            this.txtCOM.TabIndex = 22;
            // 
            // txtYMax
            // 
            this.txtYMax.Location = new System.Drawing.Point(239, 39);
            this.txtYMax.Name = "txtYMax";
            this.txtYMax.Size = new System.Drawing.Size(30, 20);
            this.txtYMax.TabIndex = 17;
            // 
            // txtYMin
            // 
            this.txtYMin.Location = new System.Drawing.Point(239, 65);
            this.txtYMin.Name = "txtYMin";
            this.txtYMin.Size = new System.Drawing.Size(30, 20);
            this.txtYMin.TabIndex = 18;
            // 
            // txtMajYGrid
            // 
            this.txtMajYGrid.Location = new System.Drawing.Point(239, 141);
            this.txtMajYGrid.Name = "txtMajYGrid";
            this.txtMajYGrid.Size = new System.Drawing.Size(30, 20);
            this.txtMajYGrid.TabIndex = 19;
            // 
            // txtMinYGrid
            // 
            this.txtMinYGrid.Location = new System.Drawing.Point(239, 167);
            this.txtMinYGrid.Name = "txtMinYGrid";
            this.txtMinYGrid.Size = new System.Drawing.Size(30, 20);
            this.txtMinYGrid.TabIndex = 20;
            // 
            // txtDataWindow
            // 
            this.txtDataWindow.Location = new System.Drawing.Point(98, 318);
            this.txtDataWindow.Name = "txtDataWindow";
            this.txtDataWindow.Size = new System.Drawing.Size(31, 20);
            this.txtDataWindow.TabIndex = 21;
            // 
            // chkConvert
            // 
            this.chkConvert.AutoSize = true;
            this.chkConvert.Location = new System.Drawing.Point(15, 208);
            this.chkConvert.Name = "chkConvert";
            this.chkConvert.Size = new System.Drawing.Size(91, 17);
            this.chkConvert.TabIndex = 22;
            this.chkConvert.Text = "Convert to 5V";
            this.chkConvert.UseVisualStyleBackColor = true;
            this.chkConvert.CheckedChanged += new System.EventHandler(this.chkConvert_CheckedChanged);
            // 
            // txtSerialData
            // 
            this.txtSerialData.Location = new System.Drawing.Point(156, 430);
            this.txtSerialData.Multiline = true;
            this.txtSerialData.Name = "txtSerialData";
            this.txtSerialData.ReadOnly = true;
            this.txtSerialData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSerialData.Size = new System.Drawing.Size(213, 87);
            this.txtSerialData.TabIndex = 23;
            // 
            // radSeconds
            // 
            this.radSeconds.AutoSize = true;
            this.radSeconds.Location = new System.Drawing.Point(11, 19);
            this.radSeconds.Name = "radSeconds";
            this.radSeconds.Size = new System.Drawing.Size(47, 17);
            this.radSeconds.TabIndex = 24;
            this.radSeconds.TabStop = true;
            this.radSeconds.Text = "Sec.";
            this.radSeconds.UseVisualStyleBackColor = true;
            // 
            // radMinutes
            // 
            this.radMinutes.AutoSize = true;
            this.radMinutes.Location = new System.Drawing.Point(13, 42);
            this.radMinutes.Name = "radMinutes";
            this.radMinutes.Size = new System.Drawing.Size(45, 17);
            this.radMinutes.TabIndex = 25;
            this.radMinutes.TabStop = true;
            this.radMinutes.Text = "Min.";
            this.radMinutes.UseVisualStyleBackColor = true;
            // 
            // txtSampleRate
            // 
            this.txtSampleRate.Location = new System.Drawing.Point(83, 253);
            this.txtSampleRate.Name = "txtSampleRate";
            this.txtSampleRate.Size = new System.Drawing.Size(31, 20);
            this.txtSampleRate.TabIndex = 26;
            // 
            // txtVref
            // 
            this.txtVref.Location = new System.Drawing.Point(83, 289);
            this.txtVref.Name = "txtVref";
            this.txtVref.Size = new System.Drawing.Size(31, 20);
            this.txtVref.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radSeconds);
            this.groupBox2.Controls.Add(this.radMinutes);
            this.groupBox2.Location = new System.Drawing.Point(156, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(58, 74);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Data Window:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Min.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Y Max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Y Min:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Max Y Grid:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Min Y Grid:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(740, 419);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 13);
            this.lblData.TabIndex = 37;
            // 
            // lblSaveLocation
            // 
            this.lblSaveLocation.AutoSize = true;
            this.lblSaveLocation.Location = new System.Drawing.Point(740, 447);
            this.lblSaveLocation.Name = "lblSaveLocation";
            this.lblSaveLocation.Size = new System.Drawing.Size(0, 13);
            this.lblSaveLocation.TabIndex = 38;
            // 
            // lblFrequency
            // 
            this.lblFrequency.Location = new System.Drawing.Point(620, 9);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(82, 43);
            this.lblFrequency.TabIndex = 39;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(693, 447);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(0, 13);
            this.lblEvent.TabIndex = 40;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(717, 9);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(0, 13);
            this.lblMin.TabIndex = 41;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(717, 39);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(0, 13);
            this.lblMax.TabIndex = 42;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(863, 524);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.lblSaveLocation);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtVref);
            this.Controls.Add(this.txtSampleRate);
            this.Controls.Add(this.txtSerialData);
            this.Controls.Add(this.chkConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataWindow);
            this.Controls.Add(this.txtMinYGrid);
            this.Controls.Add(this.txtMajYGrid);
            this.Controls.Add(this.txtYMin);
            this.Controls.Add(this.txtYMax);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkSendRequest);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.chkFilter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chkDebug);
            this.Controls.Add(this.chkSaveCSV);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkSaveCSV;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.CheckBox chkSendRequest;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnClosePort;
        private System.IO.Ports.SerialPort sp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYMax;
        private System.Windows.Forms.TextBox txtYMin;
        private System.Windows.Forms.TextBox txtMajYGrid;
        private System.Windows.Forms.TextBox txtMinYGrid;
        private System.Windows.Forms.TextBox txtDataWindow;
        private System.Windows.Forms.TextBox txtCOM;
        private System.Windows.Forms.CheckBox chkConvert;
        private System.Windows.Forms.TextBox txtSerialData;
        private System.Windows.Forms.RadioButton radSeconds;
        private System.Windows.Forms.RadioButton radMinutes;
        private System.Windows.Forms.TextBox txtSampleRate;
        private System.Windows.Forms.TextBox txtVref;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSaveLocation;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
    }
}

