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
    public partial class AdminRegister : Form
    {
        private string selectedRole;

        private const string connectionString = "Data Source=DESKTOP-6H7B0F7;Initial Catalog=SWHospital;Integrated Security=True";
  
        public AdminRegister()
        {
            InitializeComponent();
            cmbRoles.SelectedIndexChanged += CmbRoles_SelectedIndexChanged;
            cmbRoles.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbRoles.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbGender.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbGender.AutoCompleteSource = AutoCompleteSource.ListItems;
            AdminRegister_Load(this, EventArgs.Empty);
        }







        private void Sign_in_Click(object sender, EventArgs e)
        {
           /* login login = new login();
            login.Shoe();
            this.Hide();*/

        }

     
        private void Save_Click(object sender, EventArgs e)
        {
            // Get values from the form
            string name = Nametxt.Text;
            string phoneNumber = PhoneNumber.Text;
            string email = Email.Text;
            string gender = cmbGender.SelectedItem.ToString();
            string password = Password.Text;
            string ID = Id.Text;

            // Check if all required fields are filled
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber)
            || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(ID))
           
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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("IF EXISTS (SELECT * FROM New_staff WHERE ID = @Admin_ID AND Position = 'Admin') BEGIN INSERT INTO [Admin] (Admin_ID, Name, Gender, Email, Phone, Password) VALUES (@admin_Id, @Name, @Gender,  @Email, @PhoneNumber , @Password) END", connection);
                cmd.Parameters.AddWithValue("@Admin_ID", ID);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Password", password);

                // Execute the query
                int result = cmd.ExecuteNonQuery();

                // Refresh the data in the DataGridView
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Admin", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                // Close the connection
                connection.Close();
            }


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
        private void AdminRegister_Load(object sender, EventArgs e)
        {

            // Clear existing items in ComboBox
            cmbGender.Items.Clear();
            cmbRoles.Items.Clear();
            // Add roles to ComboBox
            cmbRoles.Items.Add("Doctor");
            cmbRoles.Items.Add("Patient");
            cmbRoles.Items.Add("Admin");
            // Add roles to ComboBox
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Male");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
