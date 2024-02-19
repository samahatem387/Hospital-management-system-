using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HosoitalSystem
{
    public partial class Operation1 : Form
    {
        public Operation1()
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

            // Check if all required fields are filled
            if (string.IsNullOrEmpty(Patient_ID) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(Phone_number)
                || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(Insurance_ID) || string.IsNullOrEmpty(Birthdate)
                || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Doctor_ID))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Check Patient_ID is exactly 5 digits and contains only numbers
            if (Patient_ID.Length != 5 || !Patient_ID.All(char.IsDigit))
            {
                MessageBox.Show("Patient ID must be exactly 5 digits and contain only numbers");
                return;
            }

            // Check Doctor_ID is exactly 5 digits and contains only numbers
            if (Doctor_ID.Length != 5 || !Doctor_ID.All(char.IsDigit))
            {
                MessageBox.Show("Doctor ID must be exactly 5 digits and contain only numbers");
                return;
            }

            // Check name contains only letters
            if (!name.All(char.IsLetter))
            {
                MessageBox.Show("Name can only contain letters");
                return;
            }
            //insure datebirth in right format

            DateTime birthdate;
            if (!DateTime.TryParse(Birthdate, out birthdate))
            {
                MessageBox.Show("Birthdate must be in the format yyyy-MM-dd");
                return;
            }
            Birthdate = birthdate.ToString("yyyy-MM-dd");
           
            // Check Insurance_ID is exactly 8 digits and contains only numbers
            if (Insurance_ID.Length != 8 || !Insurance_ID.All(char.IsDigit))
            {
                MessageBox.Show("Insurance ID must be exactly 8 digits and contain only numbers");
                return;
            }

            // Check Phone_number is exactly 11 digits and contains only numbers
            if (Phone_number.Length != 11 || !Phone_number.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be exactly 11 digits and contain only numbers");
                return;
            }

            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

            conn.Open();

            // Create an INSERT query with a WHERE clause to check for duplicates
            string query = @"INSERT INTO Patient (Patient_ID, Name, Gender, Birthdate, Insurance_ID, Phone, Address, Doctor_ID)
                 SELECT @patient_ID, @name, @gender, @birthdate, @insurance_ID, @phone, @address, @doctor_ID
                 WHERE NOT EXISTS (
                     SELECT 1 FROM Patient WHERE 
                         Patient_ID = @patient_ID AND
                         Gender = @gender AND
                         Birthdate = @birthdate AND
                         Insurance_ID = @insurance_ID AND
                         Phone = @phone AND
                         Doctor_ID = @doctor_ID
                 )";
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

            // Refresh the data in the DataGridView
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Patient", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            // Close the connection
            conn.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            Main.Show();
         
        }


    }
}
