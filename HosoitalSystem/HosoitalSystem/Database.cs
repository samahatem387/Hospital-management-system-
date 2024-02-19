using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HosoitalSystem
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            // Initialize the connection
            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

            // Open the connection
            conn.Open();

            // Create a SELECT query for the Medical_Record table
            string medicalRecordQuery = "SELECT * FROM Medical_Record";

            // Create a SqlCommand object with the query and connection object
            SqlCommand medicalRecordCmd = new SqlCommand(medicalRecordQuery, conn);

            // Create a SqlDataAdapter object with the SqlCommand object
            SqlDataAdapter medicalRecordAdapter = new SqlDataAdapter(medicalRecordCmd);

            // Create a DataTable object for the Medical_Record table
            DataTable medicalRecordTable = new DataTable();

            // Fill the DataTable object with the data from the SqlDataAdapter object
            medicalRecordAdapter.Fill(medicalRecordTable);

            // Set the DataGridView's DataSource property to the Medical_Record table
            dataGridView1.DataSource = medicalRecordTable;


            // Create a SELECT query for the Patient table
            string patientQuery = "SELECT * FROM Patient";

            // Create a SqlCommand object with the query and connection object
            SqlCommand patientCmd = new SqlCommand(patientQuery, conn);

            // Create a SqlDataAdapter object with the SqlCommand object
            SqlDataAdapter patientAdapter = new SqlDataAdapter(patientCmd);

            // Create a DataTable object for the Patient table
            DataTable patientTable = new DataTable();

            // Fill the DataTable object with the data from the SqlDataAdapter object
            patientAdapter.Fill(patientTable);

            // Set the DataGridView's DataSource property to the Patient table
            dataGridView2.DataSource = patientTable;


            // Create a SELECT query for the Doctor table
            string doctorQuery = "SELECT * FROM Doctor";

            // Create a SqlCommand object with the query and connection object
            SqlCommand doctorCmd = new SqlCommand(doctorQuery, conn);

            // Create a SqlDataAdapter object with the SqlCommand object
            SqlDataAdapter doctorAdapter = new SqlDataAdapter(doctorCmd);

            // Create a DataTable object for the Doctor table
            DataTable doctorTable = new DataTable();

            // Fill the DataTable object with the data from the SqlDataAdapter object
            doctorAdapter.Fill(doctorTable);

            // Set the DataGridView's DataSource property to the Doctor table
            dataGridView3.DataSource = doctorTable;

           
            // Create a SELECT query for the Doctor table
            string Insurance = "SELECT * FROM Insurance";

            // Create a SqlCommand object with the query and connection object
            SqlCommand insuranceCmd = new SqlCommand(Insurance, conn);

            // Create a SqlDataAdapter object with the SqlCommand object
            SqlDataAdapter insuranceAdapter = new SqlDataAdapter(insuranceCmd);

            // Create a DataTable object for the insurance table
            DataTable insuranceTable = new DataTable();

            // Fill the DataTable object with the data from the SqlDataAdapter object
            insuranceAdapter.Fill(insuranceTable);

            // Set the DataGridView's DataSource property to the insurance table
            dataGridView4.DataSource = insuranceTable;


            // Close the connection
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Main Main  = new Main();
            Main.Show();
            this.Hide();
        }
    }
}
