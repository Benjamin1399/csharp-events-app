using System;

namespace EventsApp
{
    public class TemperatureMonitorModel
    {
        public event EventHandler<string> TemperatureExceeded;

        private string TempID { get; set; }
        public double TempThreshold { get; set; }

        public TemperatureMonitorModel(string tempID, double tempThreshold)
        {
            TempID = tempID;
            TempThreshold = tempThreshold;
        }

        public void RecordTemperature(double temp)
        {
            string output = "";

            if (temp >= TempThreshold)
            {
                output = $"Temperature Sensor {TempID} has exceeded threshold";
                TemperatureExceeded?.Invoke(this, output);
            }
        }
    }
}
