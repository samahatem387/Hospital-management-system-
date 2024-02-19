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
using System.Text.RegularExpressions;
namespace HosoitalSystem
{
    public partial class Operation2 : Form
    {
        // Declare a SqlConnection object to be used for database connection
        private SqlConnection conn;

        public Operation2()
        {
            InitializeComponent();

            // Initialize the connection object with the database connection string
            conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");
        }


        private void patient_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         /*   if (!Regex.IsMatch(patient_Id.Text, @"^\d+$"))
            {
                MessageBox.Show("Patient Id should only contain numbers.");
                return;
            }
          */
          // Define the SQL query
            string query = "SELECT * FROM Patient WHERE Patient_Id = @patient_Id";

            // Create a SqlCommand object with the query and connection object
            SqlCommand command = new SqlCommand(query, conn);

            // Set the value of the @patient_Id parameter to the text of the patient_Id textbox
            command.Parameters.AddWithValue("@patient_Id", patient_Id.Text);

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
    }
}
