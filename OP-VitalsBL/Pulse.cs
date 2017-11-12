using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogleklasser
{
    public class Pulse
    {
     
        

        public double CalculatePulse()
        {
            int pulse = 0;
            for (int i = 0; i < SystoppunktList.Count - 1; i++)
            {
                if (SystoppunkList[i] >= (SystoppunkList.Max() - SystoppunkList.Max() * 0.3) && SystoppunkList[i] > SystoppunkList[i + 1] && SystoppunkList[i + 1] < (SystoppunkList.Max() - SystoppunkList.Max() * 0.3))
                {
                    pulse++;
                }
            }

            return pulse * 6;
        }
    }
}
