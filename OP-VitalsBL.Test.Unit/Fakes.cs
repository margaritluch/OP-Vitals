using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTO;

namespace OP_VitalsBL.Test.Unit
{
    public class MuckRsquaredCalculator : iRsquaredCalculator
    {
        public bool LinearRegressionCalcCalled { get; set; }

        public MuckRsquaredCalculator()
        {
            LinearRegressionCalcCalled = false;
        }
        public void LinearRegressionCalc(double[] xVals, double[] yVals, int inclusiveStart, int exclusiveEnd, out double rsquared, out double yintercept, out double slope)
        {
            LinearRegressionCalcCalled = true;
            rsquared = 0;
            yintercept = 0;
            slope = 0;
        }
    }
}
