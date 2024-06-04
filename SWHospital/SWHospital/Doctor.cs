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
using System.Text.RegularExpressions;


namespace SWHospital
{
    public partial class Doctor : Form
    {
        private const string connectionString = "Data Source=DESKTOP-6H7B0F7;Initial Catalog=SWHospital;Integrated Security=True";

        public Doctor()
        {
            InitializeComponent();
        }

        private void Schedule_Click(object sender, EventArgs e)
        {

    // Get the doctor ID
    string doctorId = DoctorIdTextBox.Text;

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        // Open the database connection
        connection.Open();

        // Create a command object with a parameterized SQL query
        SqlCommand cmd = new SqlCommand("SELECT Patient_Name, Patient_ID, Appointment_Time FROM Appointments WHERE Doctor_ID = @DoctorID", connection);
        cmd.Parameters.AddWithValue("@DoctorID", doctorId);

        // Execute the query and get the results into a DataTable
        DataTable dt = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        adapter.Fill(dt);

        // Bind the results to a DataGridView
        dataGridView1.DataSource = dt;

        // Close the database connection
        connection.Close();
    }

        }

        private void Patients_Record_Click(object sender, EventArgs e)
        {
            // Get the patient ID from the user input
           
            // Create a new SqlConnection object to connect to the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    if (!Regex.IsMatch(PatientId.Text, @"^\d+$"))
           {
               MessageBox.Show("Patient Id should only contain numbers.");
               return;
           }
         
                    string Patient_ID = PatientId.Text;

                    // Define the SQL query
                    string query = "SELECT Patient_ID, Name, Gender, Birthdate, Phone FROM Patient WHERE Patient_ID = @PatientID";

                    // Create a SqlCommand object with the query and connection object
                    SqlCommand command = new SqlCommand(query, conn);

                    // Set the value of the @patient_Id parameter to the text of the patient_Id textbox
                    command.Parameters.AddWithValue("@PatientID", PatientId.Text);

                    // Open the database connection
                    conn.Open();

                    // Execute the query and store the results in a DataTable object
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }

                    // Bind the DataTable to the DataGridView control
                    dataGridView1.DataSource = dataTable;

                    // Close the database connection
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving the patient: " + ex.Message);
                }
            }
        }

        private void Medical_inventory_Click(object sender, EventArgs e)
        {
            /// Create a new SqlConnection object to connect to the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Create a new SqlCommand object to execute the SELECT statement
                    string sql = "SELECT Name, Expiration_Date, Quantity FROM Medical_inventory";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Create a new SqlDataReader object to read the results
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Display the results in a DataGridView control
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;

                    // Close the reader and the connection
                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving the medical inventory: " + ex.Message);
                }
            }
        }


    }
}
