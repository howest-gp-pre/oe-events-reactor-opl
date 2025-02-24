using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Events.Core.Services
{
    public class WarningService
    {
        public void HighTemperatureWarning(object sender, EventArgs eventargs)
        {
            Console.WriteLine($"High temperature detected at {DateTime.Now}");
        }
        public void LowTemperatureWarning(object sender, EventArgs eventargs)
        {
            Console.WriteLine($"Low temperature detected at {DateTime.Now}");
        }
    }
}
