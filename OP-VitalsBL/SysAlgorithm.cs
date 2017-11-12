using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace OP_VitalsBL
{
    public class Sys_Dias_Algoritme
    {
        private ChartValuesDTO SystolicValues; // et objekt af klasssen ChartValuesDTO

        // todo først laver vi en sortering og definerer en baseline, 
        //todo hvilket definerer vi ved at beregne 75% af toppunktet
        private List<double> Findmaxbesline(DAQSettingsDTO daqdto)
        {
            List<double> maxpoints = new List<double>();

            double maxpoint = daqdto.Datalist.Max();
            double baseline = maxpoint * 0.75; // her finder vi 75 procenten af maxpunktet og dermed definerer baseline
            
            foreach (var bpvalue in daqdto.Datalist)

            {
                if (bpvalue >= baseline)
                {
                    maxpoints.Add(bpvalue);
                }
                else
                {
                  maxpoints.Add(baseline);
                }
            }
            return maxpoints;
        }

        // todo her beregner vi Systoliske værdier ved hjælp af en type af bubble algoritme
        public List<ChartValuesDTO> CalcSystolic(List<double> list)
        {
            int countAhead = 1;
            double top = 0;

            List<ChartValuesDTO> chartValues = new List<ChartValuesDTO>();

            for (int i = 0; i < list.Count; i++)
            {
                // Så længe y-værdien til den tilsvarende index værdi fra listen er mindre end y-værdien foran,
                // så bliver toppunktet defineret som y-værdien foran index værdien 
                // Lige så snart vi rammer et toppunt, så er denne if's betingelse
                //ikke længere opfyldt, og derfor går den videre i koden
                if (list[i] <= list[countAhead])
                {
                    top = list[countAhead];

                }
                // Denne if loop kører kun, når den rammer et toppunkt,hvilket
                // er større end toppunktet foran. Herefter gemmes toppunktet i en liste
                if (top == list[i] && top > list[countAhead])
                {
                    SystolicValues = new ChartValuesDTO((Convert.ToDouble(i)), top);
                    chartValues.Add(SystolicValues);
                }

                countAhead++;
                //countAhead skal være mindre end samplesize. 
                //Vores nuværende samplesize er defineret i DAQSettingDTO'en
                if (countAhead == list.Count) //if(countAhead ==100) hvis vi tager 100 punkter af gangen

                {
                    countAhead--;
                }
            }
            return chartValues;
        }


    }
}



    


