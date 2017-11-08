using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;


namespace OP_VitalsDAL
{
    public class CtrlOPVitalsDAL:iOPVitalsDAL
    {
        private FileManager fileManager;
        private string path;

        public CtrlOPVitalsDAL()
        {
            fileManager = new FileManager();
        }

        public void SaveCalibration(double value, string technicianID)
        {
            fileManager.CreateCalibrationFile(value,technicianID, out path);
        }
    }

}
