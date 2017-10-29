using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;

namespace OP_VitalsPL
{
    public partial class UILogin : Form
    {
        private iOPVitalsBL currentBl;
        public UILogin(iOPVitalsBL myBl)
        {
            InitializeComponent();
            currentBl = myBl;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
