using System;
using System.Windows.Forms;
using System.Management;
using System.Linq;
using System.Data;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic; // Generating Lists
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace ArduinoLogger
{
    public partial class Form1 : Form
    {
        #region Initializing

        // Log Variables

        public double sampleSec; // The user-specific logging sample rate in seconds; Gets converted to mSec
        double majXInt = 0; // The X axis major grid interval
        double chartWindowMinutes = 1.0;
        bool filterData = false;

        public SerialPort ArduinoPort;

        public InputDataProcessor processor;

        public static string logFilename = "d:\\Repos\\.idea\\HDL Solution Software Dev SAT\\logs\\ .csv";

        #endregion

        public Form1()
        {
            InitializeComponent();

            SetupUI();

            SetupChart();

        }

        #region Methods
        public void SetupUI()
        {
            // Populate UI text boxes with initial default values
            txtCOM.Text = "4";
            txtVref.Text = "5.2";
            txtSampleRate.Text = "1";
            radSeconds.Checked = true;
            txtYMin.Text = "59.8";
            txtYMax.Text = "60.2";
            txtMajYGrid.Text = "1.0";
            txtMinYGrid.Text = "0.5";
            txtDataWindow.Text = "30.0";

            // Find active serial ports and display
            txtSerialData.AppendText("The following active COM ports were found:" + Environment.NewLine);

            List<string> portist = GetPorts();
            foreach (string s in portist)
            {
                txtSerialData.AppendText(s + Environment.NewLine);
            }

            btnLog.Enabled = false;
            btnLog.Visible = false;
            btnStop.Enabled = false;
            btnStop.Visible = false;
            btnClosePort.Enabled = false;
            btnClosePort.Visible = false;
            txtSampleRate.Visible = false;
            txtVref.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            groupBox2.Visible = false;
        }

        public void SetupChart() // Not Working :(
        {
            chart1.Series["Series1"].ChartType = SeriesChartType.Line;
            // Change data line width to 2
            chart1.Series["Series1"].BorderWidth = 3;
            chart1.Series["Series1"].Color = Color.Red;

            // X Axis Parameters
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = majXInt;
            chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Min";
            chart1.ChartAreas["ChartArea1"].AxisX.TitleForeColor = Color.Aquamarine;
            chart1.ChartAreas["ChartArea1"].AxisX.LineColor = Color.Aquamarine;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.Aquamarine;

            // Y Axis Parameters
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.Aquamarine;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = Convert.ToDouble(txtMajYGrid.Text);
            chart1.ChartAreas["ChartArea1"].AxisY.LineColor = Color.Aquamarine;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 1;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.Enabled = true;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineColor = Color.DarkGray;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.Interval = Convert.ToDouble(txtMinYGrid.Text);
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "{0.00}";

            chart1.ChartAreas["ChartArea1"].BackColor = Color.Black;
            chart1.Legends.Clear();
        }

        public List<string> GetPorts()
        {
            // This searches all the properties of the PnP bus
            //
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM " +
                "Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                // Get port names | "COM4"
                string[] portnames = SerialPort.GetPortNames();

                // Get the Caption/Description of detected Ports
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());
                List<string> portsList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();

                return portsList;
            }
        }

        public void OpenPort()
        {
            // This is called by the "Open Port" button
            ArduinoPort = new SerialPort();
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.PortName = "COM" + txtCOM.Text;



            try
            {
                ArduinoPort.Open();
                ArduinoPort.ReadTimeout = 1000;
                timer1.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Device was not detected");
                return;
            }
            while (ArduinoPort.IsOpen == false)
            {
                btnOpenPort.Text = "Opening...";
            }
            if (ArduinoPort.IsOpen)
            {
                btnOpenPort.ForeColor = Color.Red;
                btnOpenPort.BackColor = Color.LightGreen;
                btnOpenPort.Enabled = false;

                btnClosePort.Enabled = true;
                btnClosePort.Visible = true;

                btnLog.Enabled = true;
                btnLog.Visible = true;

                btnStop.Enabled = true;
                btnStop.Visible = true;

                btnClosePort.Visible = true;
                btnClosePort.Enabled = true;
            }
        }

        public void SaveListsToCSV() // Not Working :(
        {
            //
            //
            //
            //
            //
            //
            //
            //
        }

        #endregion

        #region Event Handlers

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            OpenPort();
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.Close();
                ArduinoPort.ReadTimeout = 1000;
                timer1.Stop();

                btnOpenPort.ForeColor = Color.Black;
                btnOpenPort.BackColor = Color.White;
                btnOpenPort.Enabled = true;

                btnClosePort.Enabled = false;
                btnClosePort.Visible = false;

                btnLog.Enabled = false;
                btnLog.Visible = false;

                btnStop.Enabled = false;
                btnStop.Visible = false;
            }
        }

        private void btnLog_Click(object sender, EventArgs e) // Not Working :(
        {
            chartWindowMinutes = Convert.ToDouble(txtDataWindow.Text);
            processor = new InputDataProcessor();
            btnLog.Enabled = false;
            btnLog.Text = "Logging...";
            btnLog.BackColor = Color.Yellow;

            if (chkConvert.Checked == true)
            {
                processor.convertValue = true;
                processor.vref = Convert.ToDouble(txtVref.Text);
            }

            //
            //
            //

            if (chkSendRequest.Checked == true) ;
            {
                // Get logger sample interval value in seconds
                sampleSec = double.Parse(txtSampleRate.Text);
                if (radMinutes.Checked)
                {
                    sampleSec = sampleSec * 60.0;
                }
                processor.sampleIntervalmSec = Convert.ToInt32(sampleSec * 1000);

                timer1.Enabled = true;
                timer1.Interval = processor.sampleIntervalmSec;

                // The system timer will automatically send samples at the user-specified interval.
                // Then the "data recieved event handeler" will take each sample value when detected.

                ArduinoPort.WriteLine("L");
            }

            ArduinoPort.DiscardInBuffer();

            chkConvert.Visible = false;
            chkSendRequest.Visible = false;

            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkSendRequest.Checked == true)
            {
                ArduinoPort.WriteLine("L");
            }
        }

        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            #region Process Input Data

            // Read string of data from serial port
            SerialPort sp = (SerialPort)sender;
            string inputData = sp.ReadLine();

            // Realtime determination if user wants InputDataProcessor to filter data samples
            if (chkFilter.Checked == true)
            {
                filterData = true;
            }
            else
            {
                filterData = false;
            }

            processor.ProcessInput(inputData, filterData);

            // If incoming data exceeds scrolling window time, set List<> of timeValues from 0 to the user specified window duration
            //
            if (processor.timeVal > chartWindowMinutes)
            {
                if (processor.scrollingWindowSet == false)
                {
                    processor.SetScrollingWindow();
                    processor.scrollingWindowSet = true;
                }
                processor.sampleValues.RemoveAt(0);
            }

            #endregion

            #region Plot Data

            chart1.Invoke(new MethodInvoker(
                delegate
                {
                    //
                    // Update the YMax and YMin text-boxes if the actual sample valuie exceeds the values shown in those text-boxes
                    if (processor.sampleVal > Convert.ToDouble(txtYMax.Text))
                    {
                        txtYMax.Text = $"{processor.sampleVal:F2}";
                    }
                    if (processor.sampleVal < Convert.ToDouble(txtYMax.Text))
                    {
                        txtYMax.Text = $"{processor.sampleVal:F2}";
                    }

                    //
                    //
                    //
                    //
                    //
                    //
                    chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(txtYMax.Text);
                    chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(txtYMax.Text);
                    chart1.ChartAreas["ChartArea1"].AxisY.Interval = Convert.ToDouble(txtMajYGrid.Text);
                    chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.Interval = Convert.ToDouble(txtMinYGrid.Text);
                    //

                    // Configure the chart for a scrolling window
                    if (processor.scrollingWindowSet == true)
                    {
                        chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
                        chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "{0.0}";
                        chart1.ChartAreas["ChartArea1"].AxisX.Maximum = chartWindowMinutes;

                        //
                        //
                        while (processor.timeValues.Count > processor.sampleValues.Count)
                        {
                            processor.timeValues.RemoveAt(0);
                        }
                    }
                    if (processor.timeValues.Count == processor.sampleValues.Count)
                    {
                        chart1.Series["Series1"].Points.DataBindXY(processor.timeValues, processor.sampleValues);
                    }
                    else
                    {
                        MessageBox.Show("The timeValues & sampleValues Lists need to be the same length");
                    }
                }
                ));


            //
            if (chkDebug.Checked)
            {
                txtSerialData.Invoke(new MethodInvoker(
                    delegate
                    {
                        txtSerialData.AppendText(string.Format("{0:F2} , {1:F2}",
                            processor.timeValues.Count, processor.sampleValues.Count) +
                            Environment.NewLine);
                    }
                    ));
            }

            //
            lblData.Invoke(new MethodInvoker(
                delegate
                {
                    lblData.Text = ($" {processor.sampleVal:F2} \r\n");
                }
                ));

            //
            if (chkSaveCSV.Checked == true)
            {
                using (StreamWriter sw = File.AppendText(logFilename))
                {
                    sw.WriteLine(string.Format(processor.timeVal.ToString() +
                        "," + processor.sampleVal.ToString()));
                }
            }
            #endregion
        }

        private void chkSendRequest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSendRequest.Checked == true)
            {
                txtSampleRate.Visible = true;
                label3.Visible = true;
                groupBox2.Visible = true;
            }
            else
            {
                txtSampleRate.Visible = false;
                label3.Visible = false;
                groupBox2.Visible = false;
            }
        }

        private void chkSaveCSV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSaveCSV.Checked == true)
            {
                SaveListsToCSV();
                // Each time DataRecievedEventHandler is called, append file with latest sample value
            }
            else
            {
                lblSaveLocation.Text = "";
            }
        }

        private void chkConvert_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConvert.Checked == true)
            {
                txtVref.Visible = true;
                label1.Visible = true;
            }
            else
            {
                txtVref.Visible = false;
                label1.Visible = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ArduinoPort.DataReceived -= new SerialDataReceivedEventHandler(DataRecievedHandler);
            timer1.Enabled = false;
            btnLog.Enabled = true;
            btnLog.Text = "Log";
            btnLog.BackColor = Color.LightGray;
            if (chkSaveCSV.Checked)
            {
                SaveListsToCSV();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (ArduinoPort != null)
            {
                if (ArduinoPort.IsOpen)
                {
                    ArduinoPort.Close();
                    while (ArduinoPort.IsOpen)
                    {

                    }

                }
            }
            Application.Exit();
        }
        #endregion
    }
}