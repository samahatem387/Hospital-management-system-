namespace SWHospital
{
    partial class Admin
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
            this.patient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.doctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patient
            // 
            this.patient.BackColor = System.Drawing.Color.Blue;
            this.patient.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.patient.ForeColor = System.Drawing.Color.Cornsilk;
            this.patient.Location = new System.Drawing.Point(112, 211);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(178, 39);
            this.patient.TabIndex = 0;
            this.patient.Text = "Patient ";
            this.patient.UseVisualStyleBackColor = false;
            this.patient.Click += new System.EventHandler(this.patient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(237, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose category to Manage ";
            // 
            // doctor
            // 
            this.doctor.BackColor = System.Drawing.Color.Blue;
            this.doctor.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.doctor.ForeColor = System.Drawing.Color.Cornsilk;
            this.doctor.Location = new System.Drawing.Point(541, 211);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(178, 39);
            this.doctor.TabIndex = 2;
            this.doctor.Text = "Doctor";
            this.doctor.UseVisualStyleBackColor = false;
            this.doctor.Click += new System.EventHandler(this.doctor_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 474);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patient);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button patient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doctor;
    }
}