using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace OP_VitalsDAL.Test.Unit
{
    [TestFixture]
    public class EmployeeDatabaseUnitTest
    {
        [Test]
        public void ValidateLogin_LoginOPNurse_ReturnTrue()
        {
            var uut = new EmployeeDatabase();
            var employee = new EmployeeDTO();
            employee.EmployeeID_ = "123456";
            employee.Password_ = "abc12!";
            Assert.That(uut.ValidateLogin(employee),Is.EqualTo(true));
        }


    }
}
