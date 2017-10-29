using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface iOPVitalsDAL
    {
        bool ValiderLogin(int id, string kodeord);
    }

    public interface iOPVitalsBL
    {
        
    }

    public interface iOPVitalsPL
    {
        void StartGUI();
    }
}
