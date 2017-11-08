using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CalibrationPointDTO
    {
        public double Pressure_ { get; set; }
        public double Voltage_ { get; set; }

        public CalibrationPointDTO(double voltage, double pressure)
        {
            Pressure_ = pressure;
            Voltage_ = voltage;
        }


    }
}
