using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using NationalInstruments;
using NationalInstruments.DAQmx;

namespace OP_VitalsDAL
{
    class AsyncDaq
    {
        private AnalogMultiChannelReader analogInReader;
        private NationalInstruments.DAQmx.Task myTask;
        private NationalInstruments.DAQmx.Task runningTask;
        private AsyncCallback analogCallback;
        private Thread dataInThread;
        private Thread simulateDataInThread;
        private Thread listSortThread;
        private AnalogWaveform<double>[] data;
        private List<double> dataList;
        private List<double> chartList;
        private List<double> avgList;
        private double avg;

        public List<double> getDataList { get; }
        public List<double> getChartList { get; }

        public void StartMeasurement()
        {
            if (runningTask == null)
            {
                try
                {
                    dataList = new List<double>();
                    chartList = new List<double>();
                    avgList = new List<double>();
                    // Create a new task
                    myTask = new NationalInstruments.DAQmx.Task();

                    // Create a virtual channel
                    myTask.AIChannels.CreateVoltageChannel("Dev1 / ai0", "",
                        (AITerminalConfiguration) (-1), -5, 5, AIVoltageUnits.Volts);

                    // Configure the timing parameters
                    myTask.Timing.ConfigureSampleClock("", 1000, // 1000 = frekvensen der læses med i hz
                        SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples, 100); // 100 = antal samples per læsning

                    // Verify the Task
                    myTask.Control(TaskAction.Verify);

                    runningTask = myTask;
                    analogInReader = new AnalogMultiChannelReader(myTask.Stream);
                    analogCallback = new AsyncCallback(AnalogInCallback);

                    // Use SynchronizeCallbacks to specify that the object 
                    // marshals callbacks across threads appropriately.
                    analogInReader.SynchronizeCallbacks = true;
                    analogInReader.BeginReadWaveform(100,
                        analogCallback, myTask);

                    

                    DataInToList();
                }
                catch (DaqException exception)
                {
                    // Display Errors
                    runningTask = null;
                    myTask.Dispose();
                }
            }
        }

        public void StopMeasurement()
        {
            if (runningTask != null)
            {
                // Dispose of the task
                runningTask = null;
                myTask.Dispose();
            }
        }

        private void AnalogInCallback(IAsyncResult ar)
        {
            try
            {
                if (runningTask != null && runningTask == ar.AsyncState)
                {
                    // Read the available data from the channels
                    data = analogInReader.EndReadWaveform(ar);

                    analogInReader.BeginMemoryOptimizedReadWaveform(100,
                        analogCallback, myTask, data);
                }
            }
            catch (DaqException exception)
            {
                // Display Errors
                runningTask = null;
                myTask.Dispose();
            }
        }

        private void DataInToList()
        {
            foreach (var variable in analogInReader.ReadMultiSample(100))
            {
                dataList.Add(variable);
            }
        }

        private void SortDataToList()
        {
            avg = 0;
            for (int i = 0; i < dataList.Count; i = i+10)
            {
                avg = (chartList.GetRange(i,10).Average());
                avgList.Add(avg);
            }
        }

        //private void StartData()
        //{
        //    dataInThread = new Thread(new ThreadStart());
        //}

    }
}
