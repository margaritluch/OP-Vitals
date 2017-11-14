using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace OP_VitalsBL
{
    public class MeanAlgorithm
    {

        private List<double> analyselist;

        public MeanAlgorithm()
        {
                analyselist = new List<double>();
        }
        private void beregnmean(double value,BloodpressureDTO bloodpreasure)
        {
    
            if (analyselist.Count < 3000)
            {
                analyselist.Add(value);
               
            }
            if (analyselist.Count== 3000)
            {
                bloodpreasure.meanpressure = analyselist.Average();
            }
            else
            {
                analyselist.Clear();
            }
         
        }

    }
}
