namespace SWHospital
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.Schedule = new System.Windows.Forms.Button();
            this.Patients_Record = new System.Windows.Forms.Button();
            this.Medical_inventory = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.DoctorIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PatientId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Schedule
            // 
            this.Schedule.BackColor = System.Drawing.Color.Blue;
            this.Schedule.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Schedule.ForeColor = System.Drawing.Color.Cornsilk;
            this.Schedule.Location = new System.Drawing.Point(12, 210);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(309, 79);
            this.Schedule.TabIndex = 0;
            this.Schedule.Text = "view your Schedule";
            this.Schedule.UseVisualStyleBackColor = false;
            this.Schedule.Click += new System.EventHandler(this.Schedule_Click);
            // 
            // Patients_Record
            // 
            this.Patients_Record.BackColor = System.Drawing.Color.Blue;
            this.Patients_Record.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Patients_Record.ForeColor = System.Drawing.Color.Cornsilk;
            this.Patients_Record.Location = new System.Drawing.Point(344, 210);
            this.Patients_Record.Name = "Patients_Record";
            this.Patients_Record.Size = new System.Drawing.Size(309, 79);
            this.Patients_Record.TabIndex = 1;
            this.Patients_Record.Text = "view Patient Record ";
            this.Patients_Record.UseVisualStyleBackColor = false;
            this.Patients_Record.Click += new System.EventHandler(this.Patients_Record_Click);
            // 
            // Medical_inventory
            // 
            this.Medical_inventory.BackColor = System.Drawing.Color.Blue;
            this.Medical_inventory.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Medical_inventory.ForeColor = System.Drawing.Color.Cornsilk;
            this.Medical_inventory.Location = new System.Drawing.Point(691, 210);
            this.Medical_inventory.Name = "Medical_inventory";
            this.Medical_inventory.Size = new System.Drawing.Size(309, 79);
            this.Medical_inventory.TabIndex = 2;
            this.Medical_inventory.Text = "view Medical Inventory ";
            this.Medical_inventory.UseVisualStyleBackColor = false;
            this.Medical_inventory.Click += new System.EventHandler(this.Medical_inventory_Click);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Blue;
            this.button.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.button.ForeColor = System.Drawing.Color.Cornsilk;
            this.button.Location = new System.Drawing.Point(-173, 3);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(1399, 79);
            this.button.TabIndex = 3;
            this.button.Text = "Welocme Doctor ";
            this.button.UseVisualStyleBackColor = false;
            // 
            // DoctorIdTextBox
            // 
            this.DoctorIdTextBox.Location = new System.Drawing.Point(188, 165);
            this.DoctorIdTextBox.Name = "DoctorIdTextBox";
            this.DoctorIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.DoctorIdTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please Enter Your ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(279, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(437, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // PatientId
            // 
            this.PatientId.Location = new System.Drawing.Point(553, 168);
            this.PatientId.Name = "PatientId";
            this.PatientId.Size = new System.Drawing.Size(100, 22);
            this.PatientId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please Enter Patient ID";
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 525);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatientId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorIdTextBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.Medical_inventory);
            this.Controls.Add(this.Patients_Record);
            this.Controls.Add(this.Schedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doctor";
            this.Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Schedule;
        private System.Windows.Forms.Button Patients_Record;
        private System.Windows.Forms.Button Medical_inventory;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox DoctorIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PatientId;
        private System.Windows.Forms.Label label2;
    }
}