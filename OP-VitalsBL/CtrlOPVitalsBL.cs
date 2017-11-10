using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTO;

namespace OP_VitalsBL
{
    public class CtrlOPVitalsBL:iOPVitalsBL
    {
        private iOPVitalsDAL currentDal;
        private Calibration calibration;
        private DAQSettingsDTO daqSettings;
        public  EmployeeDTO employee { get; set; }
        private RsquaredCalculator rsquaredCalculator;

        public CtrlOPVitalsBL(iOPVitalsDAL currentDal)
        {
            this.currentDal = currentDal;
            rsquaredCalculator = new RsquaredCalculator();
            calibration = new Calibration(rsquaredCalculator);
            daqSettings = new DAQSettingsDTO();
            employee = new EmployeeDTO();
        }

        public void AddToCalibrationlist(double pressure)
        {
            calibration.AddMeasurePoint(pressure);
        }

        public void LinearRegression(List<CalibrationPointDTO> list)
        {
            calibration.LinearRegression(list);
            daqSettings.ConversionConstant_ = calibration.Slope_;
        }

        public List<CalibrationPointDTO> GetCalibrationList()
        {
            return calibration.calibrationlist_;
        }

        public double GetYintercept_()
        {
            return calibration.Yintercept_;
        }

        public double GetRsquared_()
        {
            return calibration.Rsquared_;
        }

        public double GetSlope_()
        {
            return calibration.Slope_;
        }

        public void SaveCalibration()
        {
            currentDal.SaveCalibration(calibration.Slope_,employee.EmployeeID_);
        }

        public void StartMeasurement()
        {
            currentDal.StartMeasurement();
        }

        public void StopMeasurement()
        {
            currentDal.StopMeasurement();
        }

        public List<double> GetChartList()
        {
            return currentDal.GetChartList();
        }

        public bool ValidateLogin(EmployeeDTO Employee)
        {
            return currentDal.ValidateLogin(Employee);
        }
    }
}
