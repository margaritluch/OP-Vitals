using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.IO.Compression;
using System.IO;


namespace OP_VitalsDAL
{
    class ClinicalDatabase
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
            string zipfolderpathdata = @"C:\Users\Maiken Guldberg\Documents\3. Semester\Semesterprojekt\OP-Vitals\Test.zip";
            string zipfolderpathComment = @"C:\Users\Maiken Guldberg\Documents\3. Semester\Semesterprojekt\OP-Vitals\Test.zip";
            string insertStringParamOperation = @"INSERT INTO Operation(OPNurseFirstName, OPNurseLastName, OPNurseIDNumber, NumberOFAlarms, Comments, DurationOperation_hour, DurationOperation_min, DurationOperation_sec, PatientCPR, Complikations)
                                        OUTPUT INSERTED.OperationID
                                        VALUES(@OPNurseFirstName, @OPNurseLastName, @OPNurseIDNumber, @NumberOFAlarms, @Comments, @DurationOperation_hour, @DurationOperation_min, @DurationOperation_sec, @PatientCPR, @Complikations)";
            byte[] Comment = File.ReadAllBytes(zipfolderpathComment);
            using (SqlCommand cmd = new SqlCommand(insertStringParamOperation, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@OPNurseFirstName", employee.FirstName_);
                cmd.Parameters.AddWithValue("@OPNurseLastName", employee.FirstName_);
                cmd.Parameters.AddWithValue("@OPNurseIDNumber", employee.EmployeeID_);
                cmd.Parameters.AddWithValue("@NumberOFAlarms", operation.NumberOfAlarms_);
                cmd.Parameters.AddWithValue("@Comments", Comment); //overvej om kommentarer skal gemmes som en fil
                cmd.Parameters.AddWithValue("@DurationOperation_hour", operation.DurationOperation_hour_);
                cmd.Parameters.AddWithValue("@DurationOperation_min", operation.DurationOperation_min_);
                cmd.Parameters.AddWithValue("@DurationOperation_sec", operation.DurationOperation_sec_);
                cmd.Parameters.AddWithValue("@PatientCPR", patient.PatientCPR);
                cmd.Parameters.AddWithValue("@Complikations", operation.Complikations_);

                OperationID_ = (long)cmd.ExecuteScalar();

            }

            string insertStringParamBPDataSequence = @"INSERT INTO BPDataSequence( Raw_Data, Samplerate_hz, Interval_sec, NumberOfSequences, SequenceDuration_sec, Data_Format, Bin_or_Text, Measurement_Format_Type, ConversionConstant_mmhgprmV, ZeroPoint_mmhg, Transdusor_Identification, OperationID )
                                        OUTPUT INSERTED.BPdataID 
                                        VALUES(@Raw_Data,@Samplerate_hz, @Interval_sec, @NumberOfSequences, @SequenceDuration_sec, @Data_Format, @Bin_or_Text, @Measurement_Format_Type,@ConversionConstant_mmhgprmV,@ZeroPoint_mmhg,@Transdusor_Identification,@OperationID)";

            byte[] Raw_Data = File.ReadAllBytes(zipfolderpathdata);

            using (SqlCommand cmd = new SqlCommand(insertStringParamBPDataSequence, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@Raw_Data", Raw_Data);
                cmd.Parameters.AddWithValue("@Samplerate_hz", DAQ.SampleRate);
                cmd.Parameters.AddWithValue("@Interval_sec", CalculateInterval(DAQ.SampleRate, DAQ.Samples));
                cmd.Parameters.AddWithValue("@NumberOfSequences", dataSequence.NumberOfSequences_);
                cmd.Parameters.AddWithValue("@SequenceDuration_sec", dataSequence.SequenceDuration_sec_);
                cmd.Parameters.AddWithValue("@Data_Format", DAQ.Data_Format_);
                cmd.Parameters.AddWithValue("@Bin_or_Text", DAQ.Bin_or_text_);
                cmd.Parameters.AddWithValue("@Measurement_Format_Type", DAQ.Data_Format_);
                cmd.Parameters.AddWithValue("@ConversionConstant_mmhgprmV", operation.ConversionConstant_);
                cmd.Parameters.AddWithValue("@ZeroPoint_mmhg", operation.ZeroPoint_);
                cmd.Parameters.AddWithValue("@Transdusor_Identification", transdusor.Transdusor_Identification_);
                cmd.Parameters.AddWithValue("@OperationID", OperationID_);

                BPdataID_ = (int)cmd.ExecuteScalar();
            }
            return saved;
        }

    }
}
