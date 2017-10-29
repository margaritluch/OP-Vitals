using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace OP_VitalsDAL
{
    class MedarbejderDatabase
    {
        private SqlDataReader rdr; // Datalæseren
        private SqlCommand cmd;
        private const String db = "F17ST2ITS2201607660";

        private SqlConnection OpenConnection
        {
            get
            {
                var connLocal = new SqlConnection("Data Source=i4dab.ase.au.dk;Initial Catalog=" + db + ";Persist Security Info=True;User ID=" + db + ";Password=" + db + "");

                connLocal.Open();

                return connLocal;
            }
        }

        public bool ValiderLogin(EmployeeDTO Employee)
        {
            bool result_ = false;
            cmd = new SqlCommand("select * from EmployeeDatabase where EmployeeID =" + Employee.EmployeeID_ + "and Password =" + Employee.Password_ , OpenConnection);

            rdr = cmd.ExecuteReader(); //iterator løber det igennem

            if (rdr.Read() == true)
            {
                result_ = true;
                //indsæt data fra database

                Employee.FirstName_ = rdr.GetString(1); //rdr["FirstName"]
                Employee.LastName_ = rdr.GetString(2); // rdr["LastName"]
                Employee.Profession_ = rdr.GetString(3);
                //Tjek at det er de rigtige værdier der indlæses
            }
            
            OpenConnection.Close();
            return result_;
        }


    }
}
