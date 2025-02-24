using Pre.Events.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Events.Core.Events
{
    public class TemperatureSensor
    {
        public delegate void TemperatureHandler(object sender, TemperatureEventArgs temperatureEventArgs);

        public event TemperatureHandler HighTemperatureEventHandler;
        public event TemperatureHandler LowTemperatureEventHandler;

        private readonly Random _random = new Random();

        public void GenerateTemperature()
        {
            var temperature = _random.Next(-100, 100);
            var temperatureEventArgs = new TemperatureEventArgs();
            temperatureEventArgs.Temperature = temperature;
            Console.WriteLine($"Temperature registered = {temperature}");
            if(temperature > 75)
            {
                HighTemperatureEventHandler.Invoke(this, temperatureEventArgs);
            }
            if(temperature < 0)
            {
                LowTemperatureEventHandler.Invoke(this, temperatureEventArgs);
            }
        }
    }
}
