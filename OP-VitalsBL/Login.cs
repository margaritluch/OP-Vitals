using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace OP_VitalsBL
{
    class Login
    {
        private iOPVitalsDAL currentDal;
        

        public Login(iOPVitalsDAL currentDal)
        {
            this.currentDal = currentDal;
        }
        
        public bool LoginMetode(int id, string kodeord)
        {
            return currentDal.ValiderLogin(id,kodeord);
        }

        public bool IsOPNurse()
    }
}
