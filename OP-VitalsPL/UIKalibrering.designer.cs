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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.TrykTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddMButton = new System.Windows.Forms.Button();
            this.DeleteMPointButton = new System.Windows.Forms.Button();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CalibrationLogOut = new System.Windows.Forms.Button();
            this.CalibrationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Measurepoints = new System.Windows.Forms.ListView();
            this.Volts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pressure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.CalibrationChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalibrering af OP-Vitals";
            // 
            // TrykTextBox
            // 
            this.TrykTextBox.Location = new System.Drawing.Point(76, 31);
            this.TrykTextBox.Name = "TrykTextBox";
            this.TrykTextBox.Size = new System.Drawing.Size(80, 20);
            this.TrykTextBox.TabIndex = 2;
            this.TrykTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrykTextBox_KeyDown);
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
            this.AddMButton.Location = new System.Drawing.Point(179, 29);
            this.AddMButton.Name = "AddMButton";
            this.AddMButton.Size = new System.Drawing.Size(75, 23);
            this.AddMButton.TabIndex = 6;
            this.AddMButton.Text = "Tilføj Måling";
            this.AddMButton.UseVisualStyleBackColor = true;
            this.AddMButton.Click += new System.EventHandler(this.AddMButton_Click);
            // 
            // DeleteMPointButton
            // 
            this.DeleteMPointButton.Location = new System.Drawing.Point(21, 387);
            this.DeleteMPointButton.Name = "DeleteMPointButton";
            this.DeleteMPointButton.Size = new System.Drawing.Size(110, 32);
            this.DeleteMPointButton.TabIndex = 9;
            this.DeleteMPointButton.Text = "Slet Målepunkt";
            this.DeleteMPointButton.UseVisualStyleBackColor = true;
            this.DeleteMPointButton.Click += new System.EventHandler(this.DeleteMPointButton_Click);
            // 
            // RTextBox
            // 
            this.RTextBox.Enabled = false;
            this.RTextBox.Location = new System.Drawing.Point(937, 140);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.ReadOnly = true;
            this.RTextBox.Size = new System.Drawing.Size(111, 20);
            this.RTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(898, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "R^2";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(934, 437);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(114, 38);
            this.AcceptButton.TabIndex = 12;
            this.AcceptButton.Text = "Godkend";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CalibrationLogOut
            // 
            this.CalibrationLogOut.Location = new System.Drawing.Point(973, 27);
            this.CalibrationLogOut.Name = "CalibrationLogOut";
            this.CalibrationLogOut.Size = new System.Drawing.Size(75, 23);
            this.CalibrationLogOut.TabIndex = 14;
            this.CalibrationLogOut.Text = "Log ud";
            this.CalibrationLogOut.UseVisualStyleBackColor = true;
            // 
            // CalibrationChart
            // 
            this.CalibrationChart.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.CalibrationChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.CalibrationChart.Legends.Add(legend3);
            this.CalibrationChart.Location = new System.Drawing.Point(288, 72);
            this.CalibrationChart.Name = "CalibrationChart";
            this.CalibrationChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.Name = "Punkter";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "LineærRegression";
            this.CalibrationChart.Series.Add(series5);
            this.CalibrationChart.Series.Add(series6);
            this.CalibrationChart.Size = new System.Drawing.Size(789, 300);
            this.CalibrationChart.TabIndex = 16;
            this.CalibrationChart.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TrykTextBox);
            this.groupBox1.Controls.Add(this.AddMButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 70);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // Measurepoints
            // 
            this.Measurepoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Volts,
            this.Pressure});
            this.Measurepoints.FullRowSelect = true;
            this.Measurepoints.GridLines = true;
            this.Measurepoints.Location = new System.Drawing.Point(21, 169);
            this.Measurepoints.Name = "Measurepoints";
            this.Measurepoints.Size = new System.Drawing.Size(210, 200);
            this.Measurepoints.TabIndex = 18;
            this.Measurepoints.UseCompatibleStateImageBehavior = false;
            this.Measurepoints.View = System.Windows.Forms.View.Details;
            // 
            // Volts
            // 
            this.Volts.Text = "Spænding(mV)";
            this.Volts.Width = 100;
            // 
            // Pressure
            // 
            this.Pressure.Text = "Pressure(mmHg)";
            this.Pressure.Width = 106;
            // 
            // UIKalibrering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 559);
            this.Controls.Add(this.Measurepoints);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CalibrationLogOut);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RTextBox);
            this.Controls.Add(this.DeleteMPointButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalibrationChart);
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
        private System.Windows.Forms.DataVisualization.Charting.Chart CalibrationChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView Measurepoints;
        private System.Windows.Forms.ColumnHeader Volts;
        private System.Windows.Forms.ColumnHeader Pressure;
    }
}