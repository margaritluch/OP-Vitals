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

        public CtrlOPVitalsBL(iOPVitalsDAL currentDal)
        {
            this.currentDal = currentDal;
        }
    }
}
