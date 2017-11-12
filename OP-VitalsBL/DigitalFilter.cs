using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_VitalsBL
{
    public class DigitalFilter
    {
         bool filterturnedOn;

        public DigitalFilter()
        {
            bool filterturnedOn = true;
        }

        public void turnfilterOn()
        {
            filterturnedOn = true;
        }

        public void turnfilterOff()
        {
            filterturnedOn = false;
        }


    }
}
