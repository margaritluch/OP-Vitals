using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.Design;
using Interfaces;
using System.Threading;

namespace OP_VitalsPL
{
    public partial class UIKontrolform : Form
    {
        private iOPVitalsBL currentBl;
        private Thread ChartThread_;
        public UIKontrolform(iOPVitalsBL mybl)
        {
            this.currentBl = mybl;
            InitializeComponent();
        }

        

        private void StartKontrolButton_Click(object sender, EventArgs e)
        {
            currentBl.StartMeasurement();
            Start();
        }

        private void StopKontrolButton_Click(object sender, EventArgs e)
        {
            currentBl.StopMeasurement();
        }

        private void Start()
        {
            ChartThread_ = new Thread(new ThreadStart(DrawChart));
            ChartThread_.IsBackground = true;
            ChartThread_.Start();
        }
        private void DrawChart()
        {
            while (true)
            {
                if (chart1.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker) delegate { UpdateChart(); });
                }
                Thread.Sleep(100);
            }
        }

        private void UpdateChart()
        {
            chart1.Series["Series1"].Points.Clear();
            for (int i = 1; i < currentBl.GetChartList().Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, currentBl.GetChartList());
            }
        }
    }
}
