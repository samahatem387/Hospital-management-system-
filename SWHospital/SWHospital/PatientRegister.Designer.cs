namespace SWHospital
{
    partial class PatientRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRegister));
            this.button1 = new System.Windows.Forms.Button();
            this.Idlabel = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.Birthdate = new System.Windows.Forms.TextBox();
            this.NameLabel1 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(111, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 88);
            this.button1.TabIndex = 47;
            this.button1.Text = "Already registered? Sign in ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Idlabel.Location = new System.Drawing.Point(92, 330);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(204, 32);
            this.Idlabel.TabIndex = 46;
            this.Idlabel.Text = "Your ID Will be :";
            // 
            // Id
            // 
            this.Id.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Id.Location = new System.Drawing.Point(317, 324);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(154, 38);
            this.Id.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1139, 501);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(29, 34);
            this.dataGridView1.TabIndex = 44;
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.BirthdateLabel.Location = new System.Drawing.Point(626, 158);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(111, 32);
            this.BirthdateLabel.TabIndex = 41;
            this.BirthdateLabel.Text = "Birthday";
            // 
            // Birthdate
            // 
            this.Birthdate.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Birthdate.Location = new System.Drawing.Point(754, 164);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(154, 38);
            this.Birthdate.TabIndex = 40;
            // 
            // NameLabel1
            // 
            this.NameLabel1.AutoSize = true;
            this.NameLabel1.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.NameLabel1.Location = new System.Drawing.Point(194, 164);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(83, 32);
            this.NameLabel1.TabIndex = 39;
            this.NameLabel1.Text = "Name";
            // 
            // Nametxt
            // 
            this.Nametxt.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Nametxt.Location = new System.Drawing.Point(317, 167);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(154, 38);
            this.Nametxt.TabIndex = 38;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.Location = new System.Drawing.Point(631, 320);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(121, 32);
            this.PasswordLabel.TabIndex = 35;
            this.PasswordLabel.Text = "Password";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(754, 317);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(154, 38);
            this.Password.TabIndex = 34;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.GenderLabel.Location = new System.Drawing.Point(631, 243);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(99, 32);
            this.GenderLabel.TabIndex = 31;
            this.GenderLabel.Text = "Gender";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(121, 243);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(190, 32);
            this.PhoneNumberLabel.TabIndex = 29;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.PhoneNumber.Location = new System.Drawing.Point(317, 243);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(154, 38);
            this.PhoneNumber.TabIndex = 28;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Blue;
            this.Save.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Save.ForeColor = System.Drawing.Color.Cornsilk;
            this.Save.Location = new System.Drawing.Point(468, 382);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(244, 53);
            this.Save.TabIndex = 27;
            this.Save.Text = "Create Account";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(754, 236);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(154, 39);
            this.cmbGender.TabIndex = 51;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(-2, -3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1067, 59);
            this.button2.TabIndex = 52;
            this.button2.Text = "Patient Registration";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(223, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 32);
            this.label2.TabIndex = 54;
            this.label2.Text = "Change Role to: ";
            // 
            // cmbRoles
            // 
            this.cmbRoles.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(510, 82);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(277, 39);
            this.cmbRoles.TabIndex = 53;
            // 
            // PatientRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Idlabel);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BirthdateLabel);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.NameLabel1);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientRegister";
            this.Text = "PatientRegister";
            this.Load += new System.EventHandler(this.PatientRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Label BirthdateLabel;
        protected System.Windows.Forms.TextBox Birthdate;
        protected System.Windows.Forms.Label NameLabel1;
        protected System.Windows.Forms.TextBox Nametxt;
        protected System.Windows.Forms.Label PasswordLabel;
        protected System.Windows.Forms.TextBox Password;
        protected System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoles;
    }
}