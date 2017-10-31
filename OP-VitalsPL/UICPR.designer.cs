namespace OP_VitalsPL
{
    partial class UICPR
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
            this.label1 = new System.Windows.Forms.Label();
            this.CPRTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CPRFindesIkkeCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UICPROKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Information :";
            // 
            // CPRTextBox
            // 
            this.CPRTextBox.Location = new System.Drawing.Point(102, 57);
            this.CPRTextBox.Name = "CPRTextBox";
            this.CPRTextBox.Size = new System.Drawing.Size(145, 20);
            this.CPRTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPR";
            // 
            // CPRFindesIkkeCheckBox
            // 
            this.CPRFindesIkkeCheckBox.AutoSize = true;
            this.CPRFindesIkkeCheckBox.Location = new System.Drawing.Point(78, 99);
            this.CPRFindesIkkeCheckBox.Name = "CPRFindesIkkeCheckBox";
            this.CPRFindesIkkeCheckBox.Size = new System.Drawing.Size(102, 17);
            this.CPRFindesIkkeCheckBox.TabIndex = 3;
            this.CPRFindesIkkeCheckBox.Text = "CPR findes ikke";
            this.CPRFindesIkkeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // UICPROKButton
            // 
            this.UICPROKButton.Location = new System.Drawing.Point(172, 155);
            this.UICPROKButton.Name = "UICPROKButton";
            this.UICPROKButton.Size = new System.Drawing.Size(75, 23);
            this.UICPROKButton.TabIndex = 10;
            this.UICPROKButton.Text = "OK";
            this.UICPROKButton.UseVisualStyleBackColor = true;
            // 
            // UICPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 220);
            this.Controls.Add(this.UICPROKButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPRFindesIkkeCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CPRTextBox);
            this.Controls.Add(this.label1);
            this.Name = "UICPR";
            this.Text = "UICPR";
            this.Load += new System.EventHandler(this.UICPR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CPRTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CPRFindesIkkeCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UICPROKButton;
    }
}