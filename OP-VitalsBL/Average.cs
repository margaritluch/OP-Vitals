using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using DTO_BT

namespace Nogleklasser
{
    class Average
    {
        public double average_; //middelblodtryk eller på eng. mean arterial pressure

    
        public void CalculateAverage(DTO_BT DTOBT)
        {
            average_ = ((2 * DTOBT.Dia_) + DTOBT.Sys_) / 3;
            
        }
    }
}
