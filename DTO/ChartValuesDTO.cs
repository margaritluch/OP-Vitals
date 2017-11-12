using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChartValuesDTO
    {
        public double Time { get; set; }
        public double Voltage { get; set; }

        public ChartValuesDTO(double time, double voltage)
        {
            Time = time;
            Voltage = voltage;
        }
    }
}

