namespace HosoitalSystem
{
    partial class Insurance_company
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insurance_company));
            this.Load = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.Insurance_IDTextBox = new System.Windows.Forms.TextBox();
            this.ADDRESS = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.Insurance_ID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.addData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.AutoSize = true;
            this.Load.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Load.Location = new System.Drawing.Point(391, 126);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(218, 32);
            this.Load.TabIndex = 103;
            this.Load.Text = "Insurance_Load";
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.deleteButton.Location = new System.Drawing.Point(787, 384);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 102;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.CornflowerBlue;
            this.back.Location = new System.Drawing.Point(397, 378);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(183, 51);
            this.back.TabIndex = 101;
            this.back.Text = "Back to main";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Insurance_IDTextBox
            // 
            this.Insurance_IDTextBox.Location = new System.Drawing.Point(197, 121);
            this.Insurance_IDTextBox.Name = "Insurance_IDTextBox";
            this.Insurance_IDTextBox.Size = new System.Drawing.Size(103, 22);
            this.Insurance_IDTextBox.TabIndex = 100;
            this.Insurance_IDTextBox.TextChanged += new System.EventHandler(this.Insurance_IDTextBox_TextChanged);
            // 
            // ADDRESS
            // 
            this.ADDRESS.AutoSize = true;
            this.ADDRESS.Location = new System.Drawing.Point(74, 245);
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(74, 17);
            this.ADDRESS.TabIndex = 99;
            this.ADDRESS.Text = "ADDRESS";
            this.ADDRESS.Click += new System.EventHandler(this.ADDRESS_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(200, 245);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 22);
            this.addressTextBox.TabIndex = 98;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // Insurance_ID
            // 
            this.Insurance_ID.AutoSize = true;
            this.Insurance_ID.Location = new System.Drawing.Point(74, 126);
            this.Insurance_ID.Name = "Insurance_ID";
            this.Insurance_ID.Size = new System.Drawing.Size(104, 17);
            this.Insurance_ID.TabIndex = 97;
            this.Insurance_ID.Text = "INSURANCE ID";
            this.Insurance_ID.Click += new System.EventHandler(this.Insurance_ID_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(774, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 96;
            this.label6.Text = "DISPLAY";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.Location = new System.Drawing.Point(74, 196);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(48, 17);
            this.EMAIL.TabIndex = 95;
            this.EMAIL.Text = "EMAIL";
            this.EMAIL.Click += new System.EventHandler(this.EMAIL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "COMPANY NAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(625, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(360, 204);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(200, 196);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(103, 22);
            this.emailTextBox.TabIndex = 92;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(200, 158);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(103, 22);
            this.name.TabIndex = 91;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // addData
            // 
            this.addData.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addData.Location = new System.Drawing.Point(105, 378);
            this.addData.Name = "addData";
            this.addData.Size = new System.Drawing.Size(225, 51);
            this.addData.TabIndex = 90;
            this.addData.Text = "add new  Insurance data";
            this.addData.UseVisualStyleBackColor = false;
            this.addData.Click += new System.EventHandler(this.addData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(475, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 89;
            this.label1.Text = "Insurance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(728, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 17);
            this.label10.TabIndex = 104;
            this.label10.Text = "(Please Select row to Delete )";
            // 
            // Insurance_company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 451);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Insurance_IDTextBox);
            this.Controls.Add(this.ADDRESS);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.Insurance_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.addData);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Insurance_company";
            this.Text = "Insurance_company";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Load;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox Insurance_IDTextBox;
        private System.Windows.Forms.Label ADDRESS;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label Insurance_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button addData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
    }
}