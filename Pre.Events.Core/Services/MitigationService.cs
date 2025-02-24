using Pre.Events.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Events.Core.Services
{
    public class MitigationService
    {
        public void CoolReactor(object sender, TemperatureEventArgs temperatureEventArgs)
        {
            Console.WriteLine($"Temperature is {temperatureEventArgs.Temperature} : Cooling reactor...");
        }
        public void HeatReactor(object sender, TemperatureEventArgs temperatureEventArgs)
        {
            Console.WriteLine($"Temperature is {temperatureEventArgs.Temperature} : Heating reactor...");
        }
    }
}
