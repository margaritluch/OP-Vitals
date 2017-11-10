using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;


namespace OP_VitalsDAL
{
    public class CtrlOPVitalsDAL:iOPVitalsDAL
    {
        private FileManager fileManager;
        private string path;
        private AsyncDaq DAQ;
        private EmployeeDatabase employee;

        public CtrlOPVitalsDAL()
        {
            fileManager = new FileManager();
            employee = new EmployeeDatabase();
        }

        public List<double> GetChartList()
        {
            return DAQ.getChartList;
        }

        public void SaveCalibration(double value, string technicianID)
        {
            fileManager.CreateCalibrationFile(value,technicianID, out path);
        }

        public void StartMeasurement()
        {
            DAQ.StartMeasurement();
        }

        public void StopMeasurement()
        {
            DAQ.StopMeasurement();
        }

        public bool ValidateLogin(EmployeeDTO Employee)
        {
            return employee.ValidateLogin(Employee);
        }
    }

}
