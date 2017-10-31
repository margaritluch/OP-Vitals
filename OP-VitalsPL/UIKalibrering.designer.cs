namespace OP_VitalsPL
{
    partial class UIKalibrering
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.TrykTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddMButton = new System.Windows.Forms.Button();
            this.DeleteMPointButton = new System.Windows.Forms.Button();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CalibrationLogOut = new System.Windows.Forms.Button();
            this.IndtastedeMålepunkter = new System.Windows.Forms.ListBox();
            this.CalibrationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CalibrationChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalibrering af OP-Vitals";
            // 
            // TrykTextBox
            // 
            this.TrykTextBox.Location = new System.Drawing.Point(9, 62);
            this.TrykTextBox.Name = "TrykTextBox";
            this.TrykTextBox.Size = new System.Drawing.Size(55, 20);
            this.TrykTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tryk(mmHg)";
            // 
            // AddMButton
            // 
            this.AddMButton.Location = new System.Drawing.Point(88, 43);
            this.AddMButton.Name = "AddMButton";
            this.AddMButton.Size = new System.Drawing.Size(75, 23);
            this.AddMButton.TabIndex = 6;
            this.AddMButton.Text = "Tilføj Måling";
            this.AddMButton.UseVisualStyleBackColor = true;
            // 
            // DeleteMPointButton
            // 
            this.DeleteMPointButton.Location = new System.Drawing.Point(12, 267);
            this.DeleteMPointButton.Name = "DeleteMPointButton";
            this.DeleteMPointButton.Size = new System.Drawing.Size(119, 23);
            this.DeleteMPointButton.TabIndex = 9;
            this.DeleteMPointButton.Text = "Slet Målepunkt";
            this.DeleteMPointButton.UseVisualStyleBackColor = true;
            // 
            // RTextBox
            // 
            this.RTextBox.Enabled = false;
            this.RTextBox.Location = new System.Drawing.Point(64, 313);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(68, 20);
            this.RTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "R^2";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(423, 341);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 12;
            this.AcceptButton.Text = "Godkend";
            this.AcceptButton.UseVisualStyleBackColor = true;
            // 
            // CalibrationLogOut
            // 
            this.CalibrationLogOut.Location = new System.Drawing.Point(554, 341);
            this.CalibrationLogOut.Name = "CalibrationLogOut";
            this.CalibrationLogOut.Size = new System.Drawing.Size(75, 23);
            this.CalibrationLogOut.TabIndex = 14;
            this.CalibrationLogOut.Text = "Log ud";
            this.CalibrationLogOut.UseVisualStyleBackColor = true;
            // 
            // IndtastedeMålepunkter
            // 
            this.IndtastedeMålepunkter.FormattingEnabled = true;
            this.IndtastedeMålepunkter.Location = new System.Drawing.Point(12, 156);
            this.IndtastedeMålepunkter.Name = "IndtastedeMålepunkter";
            this.IndtastedeMålepunkter.Size = new System.Drawing.Size(120, 95);
            this.IndtastedeMålepunkter.TabIndex = 15;
            // 
            // CalibrationChart
            // 
            this.CalibrationChart.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.CalibrationChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CalibrationChart.Legends.Add(legend1);
            this.CalibrationChart.Location = new System.Drawing.Point(202, 7);
            this.CalibrationChart.Name = "CalibrationChart";
            this.CalibrationChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CalibrationChart.Series.Add(series1);
            this.CalibrationChart.Size = new System.Drawing.Size(449, 300);
            this.CalibrationChart.TabIndex = 16;
            this.CalibrationChart.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TrykTextBox);
            this.groupBox1.Controls.Add(this.AddMButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // UIKalibrering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CalibrationChart);
            this.Controls.Add(this.IndtastedeMålepunkter);
            this.Controls.Add(this.CalibrationLogOut);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RTextBox);
            this.Controls.Add(this.DeleteMPointButton);
            this.Controls.Add(this.label1);
            this.Name = "UIKalibrering";
            this.Text = "Kalibrering";
            ((System.ComponentModel.ISupportInitialize)(this.CalibrationChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TrykTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddMButton;
        private System.Windows.Forms.Button DeleteMPointButton;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CalibrationLogOut;
        private System.Windows.Forms.ListBox IndtastedeMålepunkter;
        private System.Windows.Forms.DataVisualization.Charting.Chart CalibrationChart;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}