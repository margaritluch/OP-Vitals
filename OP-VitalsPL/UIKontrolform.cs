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
            
           
        }

        private void StopKontrolButton_Click(object sender, EventArgs e)
        {
            
        }

       
        

       
    }
}
