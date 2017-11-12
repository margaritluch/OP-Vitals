using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OP_VitalsBL;

namespace OP_VitalsBL.Test.Unit
{
    [TestFixture]
    class RsquaredCalculatorUnitTests
    {
        private RsquaredCalculator uut_;
        [SetUp]

        public void SetUp()
        {
            uut_ = new RsquaredCalculator();
        }

        [TestCase(new double[]{1,2,3,4},new double[]{2,3,4,5},0,3,1)]
        [TestCase(new double[]{-3,1,5},new double[]{1,2,8},0,3,0.85465)]
        [TestCase(new double[]{150,160,165,175,180,185,200,210,215,220},new double[]{2.24,2.48,2.61,3.03,3.35,3.44,4.48,4.43,4.60,4.76},0,10,0.97450)]
        public void LinearRegressionCalc_ValidValuesRsquard_ReturnsCurrectly(double[] xVals, double[] yVals, int inclusiveStart, int exclusiveEnd, double rsquardresult)
        {
            double rsquared = 0;
            double yintercept = 0;
            double slope = 0;
            uut_.LinearRegressionCalc(xVals, yVals, inclusiveStart, exclusiveEnd, out rsquared, out yintercept,
                out slope);
            
            Assert.IsTrue(Math.Round(rsquared,5) == rsquardresult);
        }

        [TestCase(new double[] { 1, 2, 3, 4 }, new double[] { 2, 3, 4, 5 }, 0, 3, 1)]
        [TestCase(new double[] { -3, 1, 5 }, new double[] { 1, 2, 8 }, 0, 3, 2.792)]
        [TestCase(new double[] { 150, 160, 165, 175, 180, 185, 200, 210, 215, 220 }, new double[] { 2.24, 2.48, 2.61, 3.03, 3.35, 3.44, 4.48, 4.43, 4.60, 4.76 }, 0, 10, -3.685)]
        public void LinearRegressionCalc_ValidValuesyintercept_ReturnsCurrectly(double[] xVals, double[] yVals, int inclusiveStart, int exclusiveEnd, double yinterceptresult)
        {
            double rsquared = 0;
            double yintercept = 0;
            double slope = 0;
            uut_.LinearRegressionCalc(xVals, yVals, inclusiveStart, exclusiveEnd, out rsquared, out yintercept,
                out slope);

            Assert.IsTrue(Math.Round(yintercept, 3) == yinterceptresult);
        }

        [TestCase(new double[] { 1, 2, 3, 4 }, new double[] { 2, 3, 4, 5 }, 0, 3, 1)]
        [TestCase(new double[] { -3, 1, 5 }, new double[] { 1, 2, 8 }, 0, 3, 0.875)]
        [TestCase(new double[] { 150, 160, 165, 175, 180, 185, 200, 210, 215, 220 }, new double[] { 2.24, 2.48, 2.61, 3.03, 3.35, 3.44, 4.48, 4.43, 4.60, 4.76 }, 0, 10, 0.039)]
        public void LinearRegressionCalc_ValidValuesslope_ReturnsCurrectly(double[] xVals, double[] yVals, int inclusiveStart, int exclusiveEnd, double sloperesult)
        {
            double rsquared = 0;
            double yintercept = 0;
            double slope = 0;
            uut_.LinearRegressionCalc(xVals, yVals, inclusiveStart, exclusiveEnd, out rsquared, out yintercept,
                out slope);

            Assert.IsTrue(Math.Round(slope, 3) == sloperesult);
        }
    }
}
