namespace OP_VitalsPL
{
    partial class UILogin
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
            this.buttonlogin = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxCodeWord = new System.Windows.Forms.TextBox();
            this.EmployeeID = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(112, 143);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(81, 27);
            this.buttonlogin.TabIndex = 0;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(112, 35);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxCodeWord
            // 
            this.textBoxCodeWord.Location = new System.Drawing.Point(112, 77);
            this.textBoxCodeWord.Name = "textBoxCodeWord";
            this.textBoxCodeWord.PasswordChar = '*';
            this.textBoxCodeWord.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodeWord.TabIndex = 2;
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.Location = new System.Drawing.Point(26, 38);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(77, 13);
            this.EmployeeID.TabIndex = 3;
            this.EmployeeID.Text = "Medarbejder id";
            this.EmployeeID.Click += new System.EventHandler(this.label1_Click);
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(29, 77);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(47, 13);
            this.code.TabIndex = 4;
            this.code.Text = "Kodeord";
            // 
            // UILogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 218);
            this.Controls.Add(this.code);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.textBoxCodeWord);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonlogin);
            this.Name = "UILogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxCodeWord;
        private System.Windows.Forms.Label EmployeeID;
        private System.Windows.Forms.Label code;
    }
}