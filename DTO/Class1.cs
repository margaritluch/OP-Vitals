using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeeDTO
    {
        public string EmployeeID_ { get; set; }
        public string FirstName_ { get; set; }
        public string LastName_ { get; set; }
        public string Password_ { get; set; } // vi antager at kodeordet kun består af tal, men man kunne overveje at have den til at bestå af både tal og bokstaver
        public string Profession_ { get; set; }
        public EmployeeDTO(string employeeID, string password,string profession)
        {
            EmployeeID_ = employeeID;
            Password_ = password;
            Profession_ = profession;
            
        }

        public EmployeeDTO()
        {
            EmployeeID_ = "123456";
            Password_ = "123456";
            Profession_ = "Test";
            FirstName_ = "No Name";
            LastName_ = "No Name";
            
        }
    }
}
