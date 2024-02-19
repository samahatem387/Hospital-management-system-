namespace HosoitalSystem
{
    partial class Operation
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
            this.Operation1 = new System.Windows.Forms.Button();
            this.Operation2 = new System.Windows.Forms.Button();
            this.Operation3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Operation1
            // 
            this.Operation1.Location = new System.Drawing.Point(124, 197);
            this.Operation1.Name = "Operation1";
            this.Operation1.Size = new System.Drawing.Size(163, 46);
            this.Operation1.TabIndex = 0;
            this.Operation1.Text = "New Patient ";
            this.Operation1.UseVisualStyleBackColor = true;
            this.Operation1.Click += new System.EventHandler(this.Operation1_Click);
            // 
            // Operation2
            // 
            this.Operation2.Location = new System.Drawing.Point(467, 197);
            this.Operation2.Name = "Operation2";
            this.Operation2.Size = new System.Drawing.Size(163, 46);
            this.Operation2.TabIndex = 1;
            this.Operation2.Text = "Get Patient Data";
            this.Operation2.UseVisualStyleBackColor = true;
            this.Operation2.Click += new System.EventHandler(this.Operation2_Click);
            // 
            // Operation3
            // 
            this.Operation3.Location = new System.Drawing.Point(786, 197);
            this.Operation3.Name = "Operation3";
            this.Operation3.Size = new System.Drawing.Size(163, 46);
            this.Operation3.TabIndex = 2;
            this.Operation3.Text = "Delete Medical Record ";
            this.Operation3.UseVisualStyleBackColor = true;
            this.Operation3.Click += new System.EventHandler(this.Operation3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(383, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Select operation to perform ";
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1069, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Operation3);
            this.Controls.Add(this.Operation2);
            this.Controls.Add(this.Operation1);
            this.Name = "Operation";
            this.Text = "Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Operation1;
        private System.Windows.Forms.Button Operation2;
        private System.Windows.Forms.Button Operation3;
        private System.Windows.Forms.Label label1;
    }
}