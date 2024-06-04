namespace SWHospital
{
    partial class ManageDoctor
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
            this.txtdoctorid = new System.Windows.Forms.TextBox();
            this.txtdoctorgender = new System.Windows.Forms.TextBox();
            this.txtdoctornumber = new System.Windows.Forms.TextBox();
            this.txtdoctorpassword = new System.Windows.Forms.TextBox();
            this.txtdoctorname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ADD = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BACK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdoctorspeciality = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.txtdoctoremail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdoctorid
            // 
            this.txtdoctorid.Location = new System.Drawing.Point(214, 126);
            this.txtdoctorid.Name = "txtdoctorid";
            this.txtdoctorid.Size = new System.Drawing.Size(200, 22);
            this.txtdoctorid.TabIndex = 0;
            // 
            // txtdoctorgender
            // 
            this.txtdoctorgender.Location = new System.Drawing.Point(214, 337);
            this.txtdoctorgender.Name = "txtdoctorgender";
            this.txtdoctorgender.Size = new System.Drawing.Size(200, 22);
            this.txtdoctorgender.TabIndex = 1;
            // 
            // txtdoctornumber
            // 
            this.txtdoctornumber.Location = new System.Drawing.Point(214, 252);
            this.txtdoctornumber.Name = "txtdoctornumber";
            this.txtdoctornumber.Size = new System.Drawing.Size(200, 22);
            this.txtdoctornumber.TabIndex = 2;
            // 
            // txtdoctorpassword
            // 
            this.txtdoctorpassword.Location = new System.Drawing.Point(214, 207);
            this.txtdoctorpassword.Name = "txtdoctorpassword";
            this.txtdoctorpassword.Size = new System.Drawing.Size(200, 22);
            this.txtdoctorpassword.TabIndex = 3;
            // 
            // txtdoctorname
            // 
            this.txtdoctorname.Location = new System.Drawing.Point(214, 88);
            this.txtdoctorname.Name = "txtdoctorname";
            this.txtdoctorname.Size = new System.Drawing.Size(200, 22);
            this.txtdoctorname.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(214, 380);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.DarkBlue;
            this.ADD.ForeColor = System.Drawing.Color.Cornsilk;
            this.ADD.Location = new System.Drawing.Point(214, 423);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(191, 48);
            this.ADD.TabIndex = 6;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.DarkBlue;
            this.DELETE.ForeColor = System.Drawing.Color.Cornsilk;
            this.DELETE.Location = new System.Drawing.Point(591, 418);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(175, 51);
            this.DELETE.TabIndex = 7;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(552, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(416, 286);
            this.dataGridView1.TabIndex = 8;
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(839, 462);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(100, 27);
            this.BACK.TabIndex = 9;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add new Patient Record Below";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Select A Patient To Delete From Below ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Speciality";
            // 
            // txtdoctorspeciality
            // 
            this.txtdoctorspeciality.Location = new System.Drawing.Point(214, 166);
            this.txtdoctorspeciality.Name = "txtdoctorspeciality";
            this.txtdoctorspeciality.Size = new System.Drawing.Size(200, 22);
            this.txtdoctorspeciality.TabIndex = 19;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(61, 303);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 22;
            this.Email.Text = "Email";
            // 
            // txtdoctoremail
            // 
            this.txtdoctoremail.Location = new System.Drawing.Point(214, 298);
            this.txtdoctoremail.Name = "txtdoctoremail";
            this.txtdoctoremail.Size = new System.Drawing.Size(200, 22);
            this.txtdoctoremail.TabIndex = 21;
            // 
            // ManageDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 519);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txtdoctoremail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdoctorspeciality);
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
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtdoctorname);
            this.Controls.Add(this.txtdoctorpassword);
            this.Controls.Add(this.txtdoctornumber);
            this.Controls.Add(this.txtdoctorgender);
            this.Controls.Add(this.txtdoctorid);
            this.Name = "ManageDoctor";
            this.Text = "ManageDoctor";
            this.Load += new System.EventHandler(this.ManageDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdoctorid;
        private System.Windows.Forms.TextBox txtdoctorgender;
        private System.Windows.Forms.TextBox txtdoctornumber;
        private System.Windows.Forms.TextBox txtdoctorpassword;
        private System.Windows.Forms.TextBox txtdoctorname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdoctorspeciality;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtdoctoremail;
    }
}