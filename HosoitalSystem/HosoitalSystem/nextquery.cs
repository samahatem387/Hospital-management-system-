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
    public partial class nextquery : Form
    {
        public nextquery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-6H7B0F7;Initial Catalog=hospital;Integrated Security=True";

            string sqlQuery = "SELECT * FROM Patient WHERE Name LIKE '%Zayn%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                try
                {
                    connection.Open();

                    // Create a new DataTable to hold the results
                    DataTable dt = new DataTable();

                    // Create a new SqlDataAdapter and fill the DataTable with the results
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);

                    // Set the DataSource property of the DataGridView to the DataTable
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=desktop-6h7b0f7;Initial Catalog=hospital;Integrated Security=True";

            string sqlQuery = "SELECT Doctor.Name AS DoctorName, COUNT(*) AS PatientCount " +
                              "FROM Patient " +
                              "JOIN Doctor ON Patient.Doctor_ID = Doctor.Doctor_ID " +
                              "GROUP BY Doctor.Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                try
                {
                    connection.Open();

                    // Create a new DataTable to hold the results
                    DataTable dt = new DataTable();

                    // Create a new SqlDataAdapter and fill the DataTable with the results
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);

                    // Set the DataSource property of the DataGridView to the DataTable
                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Database connection string
            string connectionString = "Data Source=desktop-6h7b0f7;Initial Catalog=Hospital;Integrated Security=True";

            // SQL query to fetch patient names based on insurance provider name
            string sqlQuery = "SELECT Name FROM Patient WHERE Insurance_ID = (SELECT Insurance_ID FROM Insurance WHERE Name = 'Humana')";

            // Create a new SqlConnection object with the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a new SqlDataAdapter object with the SQL query and connection object
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection);

                // Create a new DataTable object to hold the fetched data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the fetched data from the database
                dataAdapter.Fill(dataTable);

                // Set the DataSource property of the DataGridView object to the DataTable object containing the fetched data
                dataGridView3.DataSource = dataTable;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=desktop-6h7b0f7;Initial Catalog=hospital;Integrated Security=True";

            //string doctorName = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT Name FROM Doctor WHERE Specialty='Pediatrics' AND Doctor_ID NOT IN (SELECT Doctor_ID FROM Medical_Record)", connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView4.DataSource = dataTable;
                }
                else
                {
                    Console.WriteLine("No data found.");
                }

                reader.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=;Initial Catalog=hospital;Integrated Security=True";
            string query = "SELECT P.Name, COUNT(M.Record_ID) AS Total_Medical_Records " +
                           "FROM Patient P " +
                           "LEFT JOIN Medical_Record M ON P.Patient_ID = M.Patient_ID " +
                           "GROUP BY P.Name;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "MedicalRecordsPerPatient");
                dataGridView5.DataSource = dataSet.Tables["MedicalRecordsPerPatient"];
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Queries Queries = new Queries();
            Queries.Show();
            this.Hide();

        }
    }
}
