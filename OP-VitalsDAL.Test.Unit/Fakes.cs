using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace OP_VitalsDAL.Test.Unit
{
    class MuckParameterBuilder : iParameterBuilder
    {
        public bool WasAddDAQCalled { get; set; }
        public bool WasAddCommentsCalled { get; set; }
        public bool WasAddDataSequenceCalled { get; set; }
        public bool WasAddEmployeeCalled { get; set; }
        public bool WasAddOperationCalled { get; set; }
        public bool WasAddPatientCalled { get; set; }
        public bool WasAddRawDataCalled { get; set; }
        public bool WasAddTransdusorCalled { get; set; }

        public MuckParameterBuilder()
        {
            WasAddDAQCalled = false;
            WasAddCommentsCalled = false;
            WasAddDataSequenceCalled = false;
            WasAddEmployeeCalled = false;
            WasAddOperationCalled = false;
            WasAddPatientCalled = false;
            WasAddRawDataCalled = false;
            WasAddTransdusorCalled = false;
        }
        public void AddComments(SqlCommand cmd, string zipfolderpathComment)
        {
            WasAddCommentsCalled = true;
        }

        public void AddDAQ(SqlCommand cmd, DAQSettingsDTO DAQ)
        {
            WasAddDAQCalled = true;
        }

        public void AddDataSequence(SqlCommand cmd, BPDataSequenceDTO dataSequence)
        {
            WasAddDataSequenceCalled = true;
        }

        public void AddEmployee(SqlCommand cmd, EmployeeDTO employee)
        {
            WasAddEmployeeCalled = true;
        }

        public void AddOperation(SqlCommand cmd, OperationDTO operation)
        {
            WasAddOperationCalled = true;
        }

        public void AddPatient(SqlCommand cmd, PatientDTO patient)
        {
            WasAddPatientCalled = true;
        }

        public void AddRawData(SqlCommand cmd, string zipfolderpathdata)
        {
            WasAddRawDataCalled = true;
        }

        public void AddTransdusor(SqlCommand cmd, TransdusorDTO transdusor)
        {
            WasAddTransdusorCalled = true;
        }
    }
}
