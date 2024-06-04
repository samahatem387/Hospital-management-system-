namespace SWHospital
{
    partial class AdminRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegister));
            this.Sign_in = new System.Windows.Forms.Button();
            this.Idlabel = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameLabel1 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sign_in
            // 
            this.Sign_in.BackColor = System.Drawing.Color.Blue;
            this.Sign_in.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Sign_in.ForeColor = System.Drawing.Color.Cornsilk;
            this.Sign_in.Location = new System.Drawing.Point(74, 408);
            this.Sign_in.Name = "Sign_in";
            this.Sign_in.Size = new System.Drawing.Size(299, 93);
            this.Sign_in.TabIndex = 47;
            this.Sign_in.Text = "Already registered? Sign in";
            this.Sign_in.UseVisualStyleBackColor = false;
            this.Sign_in.Click += new System.EventHandler(this.Sign_in_Click);
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Idlabel.Location = new System.Drawing.Point(99, 208);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(40, 32);
            this.Idlabel.TabIndex = 46;
            this.Idlabel.Text = "ID";
            // 
            // Id
            // 
            this.Id.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Id.Location = new System.Drawing.Point(315, 205);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(154, 38);
            this.Id.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1238, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(10, 33);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NameLabel1
            // 
            this.NameLabel1.AutoSize = true;
            this.NameLabel1.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.NameLabel1.Location = new System.Drawing.Point(83, 149);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(83, 32);
            this.NameLabel1.TabIndex = 39;
            this.NameLabel1.Text = "Name";
            // 
            // Nametxt
            // 
            this.Nametxt.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Nametxt.Location = new System.Drawing.Point(315, 149);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(154, 38);
            this.Nametxt.TabIndex = 38;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.Location = new System.Drawing.Point(601, 269);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(121, 32);
            this.PasswordLabel.TabIndex = 35;
            this.PasswordLabel.Text = "Password";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(735, 263);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(154, 38);
            this.Password.TabIndex = 34;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.EmailLabel.Location = new System.Drawing.Point(629, 149);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(77, 32);
            this.EmailLabel.TabIndex = 33;
            this.EmailLabel.Text = "Email";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Email.Location = new System.Drawing.Point(735, 149);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(154, 38);
            this.Email.TabIndex = 32;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.GenderLabel.Location = new System.Drawing.Point(629, 202);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(99, 32);
            this.GenderLabel.TabIndex = 31;
            this.GenderLabel.Text = "Gender";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(85, 269);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(190, 32);
            this.PhoneNumberLabel.TabIndex = 29;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.PhoneNumber.Location = new System.Drawing.Point(315, 266);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(154, 38);
            this.PhoneNumber.TabIndex = 28;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Blue;
            this.Save.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Save.ForeColor = System.Drawing.Color.Cornsilk;
            this.Save.Location = new System.Drawing.Point(433, 337);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(234, 56);
            this.Save.TabIndex = 27;
            this.Save.Text = "Create Account ";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(735, 213);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(154, 39);
            this.cmbGender.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(276, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 52;
            this.label2.Text = "Change role to :";
            // 
            // cmbRoles
            // 
            this.cmbRoles.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(504, 55);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(277, 39);
            this.cmbRoles.TabIndex = 51;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(-228, -10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1563, 59);
            this.button2.TabIndex = 53;
            this.button2.Text = "Admin Registration";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AdminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 498);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.Sign_in);
            this.Controls.Add(this.Idlabel);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NameLabel1);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminRegister";
            this.Text = "AdminRegister";
            this.Load += new System.EventHandler(this.AdminRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sign_in;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Label NameLabel1;
        protected System.Windows.Forms.TextBox Nametxt;
        protected System.Windows.Forms.Label PasswordLabel;
        protected System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox Email;
        protected System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Button button2;
    }
}