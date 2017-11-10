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
using System.Drawing.Text;
using System.Windows.Forms.Design;
using Interfaces;
using DTO;


namespace OP_VitalsPL
{
    public partial class UIKalibrering : Form
    {
        private iOPVitalsBL currentBl;
        private UIGodkendKalibrering godkendKalibrering; //Godkend kalibrerings
        private bool PointDeletet; //Bool værdi der benyttes til at finde ud af og der er slettet et punkt fra listen af punkter der er indtastet. Denne benyttes til at finde ud af hvornår listen af punkter skal sorteres
        private UILogin login; //Loginformen
        
        public UIKalibrering(iOPVitalsBL myBl)
        {
            InitializeComponent();
            this.currentBl = myBl;
            PointDeletet = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMButton_Click(object sender, EventArgs e)
        {
           currentBl.AddToCalibrationlist(Convert.ToDouble(TrykTextBox.Text));
            if (PointDeletet == true)
            {
                SortList(currentBl.GetCalibrationList());
                PointDeletet = false;
            }
           AddPointToListView(currentBl.GetCalibrationList());
           DrawChartPoints();
            if (currentBl.GetCalibrationList().Count >= 5)
            {
                DrawLinearRegression();
                RTextBox.Text = Convert.ToString(Math.Round(currentBl.GetRsquared_(),4));
            }
            TrykTextBox.Clear();
        

        }

        private void DrawChartPoints()
        {
            for (int i = 0; i < currentBl.GetCalibrationList().Count; i++)
            {
                CalibrationChart.Series["Punkter"].Points.AddXY(currentBl.GetCalibrationList()[i].Voltage_,
                    currentBl.GetCalibrationList()[i].Pressure_);
            }
        }

        private void DrawLinearRegression()
        {
            currentBl.LinearRegression(currentBl.GetCalibrationList());
            for (int i = 0; i < 30; i++) //ret 30 til. Skal være max spændingsværdi
            {
                CalibrationChart.Series["LineærRegression"].Points
                    .AddXY(i, i * currentBl.GetSlope_() + currentBl.GetYintercept_());
            }
        }

        private void AddPointToListView(List<CalibrationPointDTO> listofpoints)
        {
            Measurepoints.Items.Clear();
            for (int i = 0; i < listofpoints.Count; i++)
            {
                ListViewItem item = new ListViewItem(Math.Round(listofpoints[i].Voltage_,3).ToString());
                item.SubItems.Add(listofpoints[i].Pressure_.ToString());
                Measurepoints.Items.Add(item);
            }
        }

        private void DeleteMPointButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Measurepoints.Items.Count; i++)
            {
                if (Measurepoints.Items[i].Selected)
                {
                    Measurepoints.Items[i].Remove();
                    currentBl.GetCalibrationList().RemoveAt(i);
                    DrawChartPoints();
                    RTextBox.Clear();
                    if (currentBl.GetCalibrationList().Count >= 5)
                    {
                        DrawLinearRegression();
                        RTextBox.Text = Convert.ToString(currentBl.GetRsquared_());
                    }
                    if (currentBl.GetCalibrationList().Count < 5)
                    {
                        CalibrationChart.Series["LineærRegression"].Points.Clear();
                    }
                    i--;
                }
            }
            PointDeletet = true;
        }

        private void SortList(List<CalibrationPointDTO> list)
        {
            list.Sort((x,y) => x.Pressure_.CompareTo(y.Pressure_));
        }

        private void TrykTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddMButton_Click(this,new EventArgs());
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            godkendKalibrering = new UIGodkendKalibrering();
            var result = godkendKalibrering.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentBl.SaveCalibration();
               this.Hide();
                login = new UILogin(currentBl);
                login.Show();

            }
            if (result == DialogResult.Cancel)
            {
                
            }
        }

        // overvej om der skal være en metode til at afrunde resultaterne
        // Der skal være en metode der sorterer punkterne så de kommer i rigtig rækkefølge når man sletter et punkt og tilføjer et nyt
    }
}
