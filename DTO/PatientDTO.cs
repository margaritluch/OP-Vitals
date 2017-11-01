using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PatientDTO
    {
        public string PatientCPR { get; set; }

        public PatientDTO()
        {
            PatientCPR = "Ikke oplyst";
        }
    }
}
