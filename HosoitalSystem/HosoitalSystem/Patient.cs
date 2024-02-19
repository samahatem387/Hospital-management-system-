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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Patient_ID = patient_ID.Text;
            string name = nameTextBox.Text;
            string Phone_number = numberTextBox.Text;
            string gender = genderTextBox.Text;
            string Insurance_ID = insurance_IDTextBox.Text;
            string Birthdate = birthdateTextBox.Text;
            string Address = addressTextBox.Text;
            string Doctor_ID = doctor.Text;



            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");


            conn.Open();

            // Create an INSERT query and replace the values with parameters
            string query = "INSERT INTO Patient (Patient_ID, Name, Gender, Birthdate, Insurance_ID, Phone, Address, Doctor_ID) VALUES (@patient_ID, @name, @gender,@birthdate,@insurance_ID,@phone,@address,doctor_ID)";

            // Create a SqlCommand object with the query and connection object
            SqlCommand cmd = new SqlCommand(query, conn);

            // Add parameter values to the SqlCommand object
            cmd.Parameters.AddWithValue("@patient_ID", Patient_ID);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@birthdate", Birthdate);
            cmd.Parameters.AddWithValue("@insurance_id", Insurance_ID);
            cmd.Parameters.AddWithValue("@phone", Phone_number);
            cmd.Parameters.AddWithValue("@address", Address);
            cmd.Parameters.AddWithValue("@doctor_ID", Doctor_ID);

            // Execute the query
            int result = cmd.ExecuteNonQuery();


            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Patient", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            // Close the connection
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            Main.Show();
            this.Hide();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

            // Open the connection
            conn.Open();

            // Create a SELECT query
            string query = "SELECT * FROM Patient";

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
    }
}
