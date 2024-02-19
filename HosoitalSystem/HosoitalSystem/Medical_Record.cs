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
    public partial class Medical_Record : Form
    {
        public Medical_Record()
        {
            InitializeComponent();
        }

        private void add_Medical_record_Click(object sender, EventArgs e)
        {

            string Record_ID = medicalTextBox.Text;
            string Patient_ID = patient_ID.Text;
            string Doctor_ID = doctor.Text;
            string Treatment = treatmentTextBox.Text;
            string Date = dateTextBox.Text;
            string Diagnosis = DiagnosisTextBox.Text;

            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

            conn.Open();

            // Create an INSERT query and replace the values with parameters
            string query = "INSERT INTO Medical_Record (Record_ID, Patient_ID, Doctor_ID, Treatment, Date, Diagnosis) VALUES (@record_ID, @Patient_ID,@Doctor_ID,@Treatment,@date, @diagnosis)";

            // Create a SqlCommand object with the query and connection object
            SqlCommand cmd = new SqlCommand(query, conn);

            // Add parameter values to the SqlCommand object
            cmd.Parameters.AddWithValue("@record_ID", Record_ID);
            cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
            cmd.Parameters.AddWithValue("@Doctor_ID", Doctor_ID);
            cmd.Parameters.AddWithValue("@Treatment", Treatment);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@diagnosis", Diagnosis);

            // Execute the query
            int result = cmd.ExecuteNonQuery();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Medical_Record", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            // Close the connection
            conn.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {


            // Initialize the connection
            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

            // Open the connection
            conn.Open();

            // Create a SELECT query
            string query = "SELECT * FROM Medical_Record";

            // Create a SqlCommand object with the query and connection object
            SqlCommand cmd = new SqlCommand(query, conn);

            // Create a SqlDataAdapter object with the SqlCommand object
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            // Create a DataTable object
            DataTable dt = new DataTable();

            // Fill the DataTable object with the data from the SqlDataAdapter object
            sda.Fill(dt);

            // Bind the DataTable object to the DataGridView
            dataGridView1.DataSource = dt;

            // Close the connection
            conn.Close();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {


            string Record_ID = dataGridView1.CurrentRow.Cells["Record_ID"].Value.ToString();

            // Initialize the connection
            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

            // Open the connection
            conn.Open();

            // Create a DELETE query
            string query = "DELETE FROM Medical_Record WHERE  = @Record_ID";

            // Create a SqlCommand object with the query and connection object
            SqlCommand cmd = new SqlCommand(query, conn);

            // Add parameter values to the SqlCommand object
            cmd.Parameters.AddWithValue("@Record_ID", Record_ID);

            // Execute the query
            int result = cmd.ExecuteNonQuery();

            // If the query was successful
            if (result > 0)
            {
                MessageBox.Show("Record deleted successfully!");

                // Refresh the DataGridView
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Medical_Record", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Record not deleted!");
            }

            // Close the connection
            conn.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            Main.Show();
            this.Hide();
        }
    }
}
