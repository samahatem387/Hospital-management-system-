namespace SWHospital
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRoles
            // 
            this.cmbRoles.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(569, 245);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(277, 39);
            this.cmbRoles.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(200, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose your Role Please ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(279, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(486, 56);
            this.button1.TabIndex = 26;
            this.button1.Text = "Already Registered? Sign in ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(-5, -9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1067, 59);
            this.button2.TabIndex = 27;
            this.button2.Text = "Registration";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRoles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}