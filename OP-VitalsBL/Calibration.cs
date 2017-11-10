using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace OP_VitalsBL
{
    public class Calibration
    {
        private iRsquaredCalculator rsquaredCalculator_;
        public List<CalibrationPointDTO> calibrationlist_ { get; set; }
        

        public Calibration(iRsquaredCalculator rsquaredCalculator)
        {
            calibrationlist_ = new List<CalibrationPointDTO>();
            xval1 = new List<double>();
            yval1 = new List<double>();
            rsquaredCalculator_ = rsquaredCalculator;
           
        }

        public void AddMeasurePoint(double voltage, double pressure)
        {
            AddToList(voltage,pressure);
        }
        private void AddToList(double voltage, double pressure)
        {
             //i stedet for random indlæses der spændingsværdier fra DAQ'en
            CalibrationPointDTO point = new CalibrationPointDTO(voltage,pressure);
            calibrationlist_.Add(point);
        }
        private List<double> xval1;
        private List<double> yval1;
        private double rsquared_;
        private double yintercept_;
        private double slope_;

        public double Yintercept_
        {
            get { return yintercept_; }
        }

        public double Rsquared_
        {
            get { return rsquared_; }
        }

        public double Slope_
        {
            get { return slope_; }
        }
        public void LinearRegression(List<CalibrationPointDTO> list)
        {

            foreach (var item in list)
            {
                xval1.Add(item.Voltage_);
                yval1.Add(item.Pressure_);
            }
            double[] xval = xval1.ToArray();
            double[] yval = yval1.ToArray();
            rsquaredCalculator_.LinearRegressionCalc(xval, yval, 0, list.Count, out rsquared_, out yintercept_, out slope_);

        }
         
        


    }
}
