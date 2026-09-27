using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitorModel bedroom = new TemperatureMonitorModel("Bedroom-01", 26.5);

            bedroom.TemperatureExceeded += Temperature_Exceeded;

            bedroom.RecordTemperature(33.5);
            bedroom.RecordTemperature(20);
        }

        private static void Temperature_Exceeded(object sender, string e)
        {
            TemperatureMonitorModel tempModel = (TemperatureMonitorModel)sender;

            Console.WriteLine($"WARNING: {tempModel.TempID} has exceeded threshold {tempModel.TempThreshold} C");
            Console.WriteLine(e);
        }
    }
}
