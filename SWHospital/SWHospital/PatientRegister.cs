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
    public partial class PatientRegister : Form
    {
        private string selectedRole;
        public PatientRegister()
        {
            InitializeComponent();
            cmbRoles.SelectedIndexChanged += CmbRoles_SelectedIndexChanged;
              cmbRoles.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbRoles.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbGender.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbGender.AutoCompleteSource = AutoCompleteSource.ListItems;
            PatientRegister_Load(this, EventArgs.Empty);

        
       
        }
        private void Save_Click(object sender, EventArgs e)
        {
            string name = Nametxt.Text;
            string phoneNumber = PhoneNumber.Text;
            string gender = cmbGender.SelectedItem.ToString(); 
            string password = Password.Text;
            string birthdate = Birthdate.Text;

            // Check if all required fields are filled
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber)
                || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(birthdate)
                || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Check name contains only letters
            if (!name.All(char.IsLetter))
            {
                MessageBox.Show("Name can only contain letters");
                return;
            }

            // Check birthdate is in the right format
            DateTime birthdateDt;
            if (!DateTime.TryParse(birthdate, out birthdateDt))
            {
                MessageBox.Show("Birthdate must be in the format yyyy-MM-dd");
                return;
            }
            birthdate = birthdateDt.ToString("yyyy-MM-dd");

            // Generate a new patient ID automatically
            Random rand = new Random();
            int newId = rand.Next(10000, 99999);

            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=SWHospital;Integrated Security=True");

            conn.Open();

            // Create an INSERT query with a WHERE clause to check for duplicates
            string query = @"INSERT INTO Patient (Patient_ID, Name, Gender, Birthdate, Phone, Password)
         SELECT @patient_ID, @name, @gender, @birthdate, @phone, @password 
         WHERE NOT EXISTS (
             SELECT 1 FROM Patient WHERE 
                 Patient_ID = @patient_ID AND
                 Phone = @phone 
         )";
            // Create a SqlCommand object with the query and connection object
            SqlCommand cmd = new SqlCommand(query, conn);

            // Add parameter values to the SqlCommand object
            cmd.Parameters.AddWithValue("@patient_ID", newId);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@birthdate", birthdate);
            cmd.Parameters.AddWithValue("@phone", phoneNumber);
            cmd.Parameters.AddWithValue("@password", password);


            // Execute the query
            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                // Display the new patient ID in the ID textbox
                Id.Text = newId.ToString();
            }
            else
            {
                MessageBox.Show("Failed to register the patient.");
            }

            // Refresh the data in the DataGridView
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Patient", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            // Close the connection
            conn.Close();

            /*  Patient Patient = new Patient();
                            Patient.show();
                            this.Hide;*/
        }

        private void CmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show text boxes based on selected role
            selectedRole = cmbRoles.SelectedItem.ToString();

            switch (selectedRole)
            {
                case "Doctor":
                    doctorRegister doctorRegister = new doctorRegister();
                    doctorRegister.Show();
                    this.Hide();


                    break;


                case "Patient":

                    PatientRegister PatientRegister = new PatientRegister();
                    PatientRegister.Show();
                    this.Hide();


                    break;
                case "Admin":

                    AdminRegister AdminRegister = new AdminRegister();
                    AdminRegister.Show();
                    this.Hide();
                    break;

                default:
                    break;
            }
        }

        private void PatientRegister_Load(object sender, EventArgs e)
        {
            // Clear existing items in ComboBox
            cmbGender.Items.Clear();
            cmbRoles.Items.Clear();
            // Add roles to ComboBox
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Male");

            // Add roles to ComboBox
            cmbRoles.Items.Add("Doctor");
            cmbRoles.Items.Add("Patient");
            cmbRoles.Items.Add("Admin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 login login = new login();
                  login.Show();
                   this.Hide();
        }

    }
}
