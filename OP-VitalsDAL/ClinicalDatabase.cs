﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.IO.Compression;
using System.IO;
using Interfaces;


namespace OP_VitalsDAL
{
    public class ClinicalDatabase
    {
        private SqlDataReader rdr; // Datalæseren
        private SqlCommand cmd;
        private const String db = "F17ST2ITS2201607660";
        private iParameterBuilder parameterBuilder_;

        private string commentfile =
            @"C:\Users\Maiken Guldberg\Documents\3. Semester\Semesterprojekt\OP-Vitals\Filingsystem\Comments.zip";

        public ClinicalDatabase(iParameterBuilder parameterBuilder)
        {
            parameterBuilder_ = parameterBuilder;
        }
        private SqlConnection OpenConnection
        {
            get
            {
                var connLocal = new SqlConnection("Data Source=i4dab.ase.au.dk;Initial Catalog=" + db + ";Persist Security Info=True;User ID=" + db + ";Password=" + db + "");

                connLocal.Open();

                return connLocal;
            }
        }

        //beregner den tid målingen er taget over ud fra sample rate i Hz og antal samples. Værdien kommer ud i sekunder
        private int CalculateInterval(int sampleRate, int samples)
        {
                int interval;
                interval = samples / sampleRate;
                return interval;
        }

        private void Zipfolder(string startPath)
        {
            string zipPath = startPath + ".zip";
            ZipFile.CreateFromDirectory(startPath, zipPath);
        }
        public bool SaveMeasurement(EmployeeDTO employee, OperationDTO operation, PatientDTO patient, DAQSettingsDTO DAQ, BPDataSequenceDTO dataSequence, TransdusorDTO transdusor)
        {
            long OperationID_;
            bool saved = true;
            int BPdataID_;
            string insertStringParamOperation = @"INSERT INTO Operation(OPNurseFirstName, OPNurseLastName, OPNurseIDNumber, NumberOFAlarms, Comments, DurationOperation_hour, DurationOperation_min, DurationOperation_sec, PatientCPR, Complikations)
                                        OUTPUT INSERTED.OperationID
                                        VALUES(@OPNurseFirstName, @OPNurseLastName, @OPNurseIDNumber, @NumberOFAlarms, @Comments, @DurationOperation_hour, @DurationOperation_min, @DurationOperation_sec, @PatientCPR, @Complikations)";
           
            using (SqlCommand cmd = new SqlCommand(insertStringParamOperation, OpenConnection))
            {
                parameterBuilder_.AddEmployee(cmd,employee);
                parameterBuilder_.AddOperation(cmd,operation);
                parameterBuilder_.AddComments(cmd,commentfile);
                parameterBuilder_.AddPatient(cmd,patient);
                OperationID_ = (long)cmd.ExecuteScalar();
            }

            string insertStringParamBPDataSequence = @"INSERT INTO BPDataSequence( Raw_Data, Samplerate_hz, Interval_sec, NumberOfSequences, SequenceDuration_sec, Data_Format, Bin_or_Text, Measurement_Format_Type, ConversionConstant_mmhgprmV, ZeroPoint_mmhg, Transdusor_Identification, OperationID )
                                        OUTPUT INSERTED.BPdataID 
                                        VALUES(@Raw_Data,@Samplerate_hz, @Interval_sec, @NumberOfSequences, @SequenceDuration_sec, @Data_Format, @Bin_or_Text, @Measurement_Format_Type,@ConversionConstant_mmhgprmV,@ZeroPoint_mmhg,@Transdusor_Identification,@OperationID)";

            using (SqlCommand cmd = new SqlCommand(insertStringParamBPDataSequence, OpenConnection))
            {
                parameterBuilder_.AddRawData(cmd,operation.PathOperationFolder_);
                parameterBuilder_.AddDAQ(cmd,DAQ);
                parameterBuilder_.AddDataSequence(cmd,dataSequence);
                parameterBuilder_.AddTransdusor(cmd,transdusor);
                cmd.Parameters.AddWithValue("@OperationID", OperationID_);

                BPdataID_ = (int)cmd.ExecuteScalar();
            }
            return saved;
        }

    }
}
