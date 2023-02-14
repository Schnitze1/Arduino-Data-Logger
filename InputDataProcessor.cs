using System;
using System.Collections.Generic;
using System.Diagnostics; // For Stopwatch

namespace ArduinoLogger
{
    public class InputDataProcessor
    {

        #region Properties

        // This boolean gets set if the input data requires conversion (ie, 0-1023 to 0.5v)
        public bool convertValue { get; set; }

        //
        public bool scrollingWindowSet { get; set; }

        //
        public string inputString { get; set; }

        //
        public int inputIntVal { get; set; }

        //
        public double sampleVal { get; set; }

        //
        public double sampleValOld { get; set; } // Used for filter

        //
        public double timeVal { get; set; }

        // These List's are the final processed data in double form, and holds samples for the entire duration of the log
        public List<double> timeValues { get; set; }
        public List<double> sampleValues { get; set; }

        // This is the 1023 value from the Arduino A/D converter, in double form
        public double rangeDouble { get; set; }

        // Describes how often, in mSec, the samples will be requested (ie, timer1 interval)
        public int sampleIntervalmSec { get; set; }
        public double sampleIntervalMinutes { get; set; }
        public double vref { get; set; }
        public Stopwatch stopwatchArduinoLog = new Stopwatch();

        #endregion

        #region Constructor 
        public InputDataProcessor()
        {
            this.timeValues = new List<double>();
            this.sampleValues = new List<double>();
            this.timeVal = 0.0;
            this.sampleValOld = 0.0;
            this.convertValue = false;
            this.sampleIntervalMinutes = 0.0;
        }

        #endregion

        #region Methods
        public void ProcessInput(string s, bool filter)
        {
            stopwatchArduinoLog.Stop();
            sampleIntervalMinutes = stopwatchArduinoLog.Elapsed.TotalSeconds / 60.0;

            // The input string "s" can be either a 0-1023 value that needs conversion to 0.5v or an already-calculated value in string form that is ready to plot
            //
            string trimmed = s.TrimEnd('\r', '\n');

            if (convertValue == true)
            {
                //
                // This method takes a strong from the DataRecievedEventHandler that looks like "1023 \r\n" and converts it to an int array of [1023]

                inputIntVal = Convert.ToInt16(trimmed);

                // Convert to Volts
                ScaleValue();
            }
            else
            {
                // If conversion is not needed, simply convert to double and remove any inherent error offset from the measuring equipment
                //
                sampleVal = Convert.ToDouble(trimmed) - 0.05;
            }

            if (filter == true)
            {
                sampleVal = 0.8 * sampleValOld + 0.2 * sampleVal;
            }

            sampleValOld = sampleVal;

            timeVal = timeVal + sampleIntervalMinutes;

            // Add new values to the timeValues List<> ONLY if the user hasnt reached the scrolling window limiter
            //
            if (scrollingWindowSet == false)
            {
                timeValues.Add(timeVal);
            }

            sampleValues.Add(sampleVal);

            stopwatchArduinoLog.Restart();
        }
        
        public void ScaleValue()
        {
            //
            // This method is called by the DataRecievedEventHandler and converts max value of 1023 to double
            double rangeDouble = 1023.0;

            // Convert the sample integer value (range 0-1023) to double
            double sampleDouble = Convert.ToDouble(inputIntVal);

            // Convert 0-1023 value to voltage value, using the Arduino vref value
            sampleVal = sampleDouble * (vref / rangeDouble);
        }

        public void SetScrollingWindow()
        {
            double tVal = 0.0;
            
            for (int i = 0; i < timeValues.Count; i++)
            {
                timeValues[i] = tVal;
                tVal = tVal + sampleIntervalMinutes;
            }
        }
        #endregion

    }
}
