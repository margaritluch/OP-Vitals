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
        private ClinicalDatabase myKliniskDatabase;
        private EmployeeDatabase myMedarbejderDatabase;

        public bool ValiderLogin(int id, string kodeord)
        {

            return myMedarbejderDatabase.ValiderLogin(id, kodeord);
        }
    }

}
