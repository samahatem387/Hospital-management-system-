namespace HosoitalSystem
{
    partial class Operation3
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
            this.Record_ID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Record_ID
            // 
            this.Record_ID.Location = new System.Drawing.Point(118, 221);
            this.Record_ID.Name = "Record_ID";
            this.Record_ID.Size = new System.Drawing.Size(100, 22);
            this.Record_ID.TabIndex = 0;
            this.Record_ID.Text = "Record ID";
            this.Record_ID.TextChanged += new System.EventHandler(this.Record_ID_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "load";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(606, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(287, 188);
            this.dataGridView1.TabIndex = 2;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(147, 413);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(170, 23);
            this.back.TabIndex = 3;
            this.back.Text = "Return  To Main";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(445, 285);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(124, 35);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please type Record Id to delete";
            // 
            // Operation3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Record_ID);
            this.Name = "Operation3";
            this.Text = "Operation3";
            this.Load += new System.EventHandler(this.Operation3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Record_ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
    }
}