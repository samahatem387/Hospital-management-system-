namespace HosoitalSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button5 = new System.Windows.Forms.Button();
            this.Medical_Records = new System.Windows.Forms.Button();
            this.DataBase = new System.Windows.Forms.Button();
            this.Doctor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InsuranceCompany = new System.Windows.Forms.Button();
            this.queries = new System.Windows.Forms.Button();
            this.Operation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(231, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 52);
            this.button5.TabIndex = 11;
            this.button5.Text = "Patient ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Medical_Records
            // 
            this.Medical_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Medical_Records.Location = new System.Drawing.Point(420, 150);
            this.Medical_Records.Name = "Medical_Records";
            this.Medical_Records.Size = new System.Drawing.Size(218, 57);
            this.Medical_Records.TabIndex = 10;
            this.Medical_Records.Text = "Medical Records ";
            this.Medical_Records.UseVisualStyleBackColor = true;
            this.Medical_Records.Click += new System.EventHandler(this.Medical_Records_Click);
            // 
            // DataBase
            // 
            this.DataBase.BackColor = System.Drawing.Color.FloralWhite;
            this.DataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DataBase.ForeColor = System.Drawing.Color.Black;
            this.DataBase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DataBase.Location = new System.Drawing.Point(899, 150);
            this.DataBase.Name = "DataBase";
            this.DataBase.Size = new System.Drawing.Size(168, 52);
            this.DataBase.TabIndex = 9;
            this.DataBase.Text = "DataBase";
            this.DataBase.UseVisualStyleBackColor = false;
            this.DataBase.Click += new System.EventHandler(this.DataBase_Click);
            // 
            // Doctor
            // 
            this.Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Doctor.Location = new System.Drawing.Point(52, 150);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(127, 52);
            this.Doctor.TabIndex = 7;
            this.Doctor.Text = "doctor";
            this.Doctor.UseVisualStyleBackColor = true;
            this.Doctor.Click += new System.EventHandler(this.doctor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 26F);
            this.label1.Location = new System.Drawing.Point(431, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hospital System ";
            // 
            // InsuranceCompany
            // 
            this.InsuranceCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuranceCompany.ImageKey = "(none)";
            this.InsuranceCompany.Location = new System.Drawing.Point(690, 150);
            this.InsuranceCompany.Name = "InsuranceCompany";
            this.InsuranceCompany.Size = new System.Drawing.Size(162, 52);
            this.InsuranceCompany.TabIndex = 12;
            this.InsuranceCompany.Text = "Insurance Company";
            this.InsuranceCompany.UseVisualStyleBackColor = true;
            this.InsuranceCompany.Click += new System.EventHandler(this.InsuranceCompany_Click);
            // 
            // queries
            // 
            this.queries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.queries.Location = new System.Drawing.Point(86, 278);
            this.queries.Name = "queries";
            this.queries.Size = new System.Drawing.Size(166, 59);
            this.queries.TabIndex = 13;
            this.queries.Text = "Queries";
            this.queries.UseVisualStyleBackColor = true;
            this.queries.Click += new System.EventHandler(this.queries_Click);
            // 
            // Operation
            // 
            this.Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Operation.Location = new System.Drawing.Point(453, 287);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(185, 50);
            this.Operation.TabIndex = 14;
            this.Operation.Text = "Operation";
            this.Operation.UseVisualStyleBackColor = true;
            this.Operation.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.queries);
            this.Controls.Add(this.InsuranceCompany);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Medical_Records);
            this.Controls.Add(this.DataBase);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Medical_Records;
        private System.Windows.Forms.Button DataBase;
        private System.Windows.Forms.Button Doctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsuranceCompany;
        private System.Windows.Forms.Button queries;
        private System.Windows.Forms.Button Operation;
    }
}