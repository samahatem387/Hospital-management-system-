namespace SWHospital
{
    partial class ManagePatient
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BACK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DELETE = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.dtpPatientDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPatientid = new System.Windows.Forms.TextBox();
            this.txtPatientGender = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Select A Patient To Delete From Below ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Add new Patient Record Below";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name:";
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(820, 467);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(100, 27);
            this.BACK.TabIndex = 28;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(533, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(416, 286);
            this.dataGridView1.TabIndex = 27;
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.DarkBlue;
            this.DELETE.ForeColor = System.Drawing.Color.Cornsilk;
            this.DELETE.Location = new System.Drawing.Point(572, 423);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(175, 51);
            this.DELETE.TabIndex = 26;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.DarkBlue;
            this.ADD.ForeColor = System.Drawing.Color.Cornsilk;
            this.ADD.Location = new System.Drawing.Point(195, 428);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(191, 48);
            this.ADD.TabIndex = 25;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // dtpPatientDOB
            // 
            this.dtpPatientDOB.Location = new System.Drawing.Point(195, 385);
            this.dtpPatientDOB.Name = "dtpPatientDOB";
            this.dtpPatientDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpPatientDOB.TabIndex = 24;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(195, 115);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(139, 22);
            this.txtPatientName.TabIndex = 23;
            // 
            // txtPatientPhoneNumber
            // 
            this.txtPatientPhoneNumber.Location = new System.Drawing.Point(195, 224);
            this.txtPatientPhoneNumber.Name = "txtPatientPhoneNumber";
            this.txtPatientPhoneNumber.Size = new System.Drawing.Size(139, 22);
            this.txtPatientPhoneNumber.TabIndex = 22;
            // 
            // txtPatientid
            // 
            this.txtPatientid.Location = new System.Drawing.Point(195, 279);
            this.txtPatientid.Name = "txtPatientid";
            this.txtPatientid.Size = new System.Drawing.Size(139, 22);
            this.txtPatientid.TabIndex = 21;
            // 
            // txtPatientGender
            // 
            this.txtPatientGender.Location = new System.Drawing.Point(195, 329);
            this.txtPatientGender.Name = "txtPatientGender";
            this.txtPatientGender.Size = new System.Drawing.Size(139, 22);
            this.txtPatientGender.TabIndex = 20;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(195, 163);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(139, 22);
            this.txtpassword.TabIndex = 19;
            // 
            // ManagePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 547);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.dtpPatientDOB);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtPatientPhoneNumber);
            this.Controls.Add(this.txtPatientid);
            this.Controls.Add(this.txtPatientGender);
            this.Controls.Add(this.txtpassword);
            this.Name = "ManagePatient";
            this.Text = "ManagePatient";
            this.Load += new System.EventHandler(this.ManagePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.DateTimePicker dtpPatientDOB;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientPhoneNumber;
        private System.Windows.Forms.TextBox txtPatientid;
        private System.Windows.Forms.TextBox txtPatientGender;
        private System.Windows.Forms.TextBox txtpassword;
    }
}