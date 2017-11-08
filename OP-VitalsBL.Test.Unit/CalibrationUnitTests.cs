using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OP_VitalsBL;
using Interfaces;

namespace OP_VitalsBL.Test.Unit
{
    [TestFixture]

    class CalibrationUnitTests
    {
        

        [Test]

        public void LinearRegression_DoLinearRegression_LinearRegressionCalcWasCalled()
        {
            var rsquaredCalculator = new MuckRsquaredCalculator();
            var uut_ = new Calibration(rsquaredCalculator);
            List<CalibrationPointDTO> list = new List<CalibrationPointDTO>();
            uut_.LinearRegression(list);
            Assert.That(rsquaredCalculator.LinearRegressionCalcCalled,Is.EqualTo(true));
        }
    }
}
