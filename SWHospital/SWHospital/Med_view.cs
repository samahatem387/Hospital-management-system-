using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SWHospital
{
    public partial class Med_view : Form
    {
        public Med_view()
        {
            InitializeComponent();
        }

        private void Med_view_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int patientId = int.Parse(textBox1.Text);

            // Create an SQL connection to the database
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6H7B0F7;Initial Catalog=SWHospital;Integrated Security=True");

            // Create the SQL command to retrieve the patient's medical record
            string sql = "SELECT * FROM Medical_Record WHERE Patient_ID = @patientId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@patientId", patientId);

            // Create a DataTable to store the medical record data
            DataTable dt = new DataTable();

            // Use a SqlDataAdapter to fill the DataTable with the medical record data
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Open the SQL connection
            conn.Open();

            // Execute the SQL command and fill the DataTable with the medical record data
            da.Fill(dt);
            conn.Close();
            // Display the medical record data in the DataGridView control
            dataGridView1.DataSource = dt;

            // Set the column headers for the DataGridView
            dataGridView1.Columns["Record_ID"].HeaderText = "Record ID";
            dataGridView1.Columns["Patient_ID"].HeaderText = "Patient ID";
            dataGridView1.Columns["Doctor_ID"].HeaderText = "Doctor ID";
            dataGridView1.Columns["Treatment"].HeaderText = "Treatment";
            dataGridView1.Columns["Date"].HeaderText = "Date";
            dataGridView1.Columns["Diagnosis"].HeaderText = "Diagnosis";
        }
    }
}