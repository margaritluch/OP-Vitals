using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace OP_VitalsBL
{
    public class PulsAlgorithm
    {
        private SysAlgorithm syses;

        public int pulseCalculation(DAQSettingsDTO daqdto)
        {
            syses = new SysAlgorithm();

            int sampleInSeconds = daqdto.Samples / daqdto.SampleRate;
            int calcFactor = 60 / sampleInSeconds;

            int pulse = syses.CalcSystolic(syses.Findmaxbaseline(daqdto)).Count * calcFactor;

            return pulse;
        }
    }
}
