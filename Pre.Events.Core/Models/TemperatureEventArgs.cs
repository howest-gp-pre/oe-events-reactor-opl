using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Events.Core.Models
{
    public class TemperatureEventArgs : EventArgs
    {
        public double Temperature { get; set; }
    }
}
