using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWHospital
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
                 comboboxposition.Items.Add("Patient");
            comboboxposition.Items.Add("Doctor");
            comboboxposition.Items.Add("Admin");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string userId = txtUserID.Text;
            string password = txtPassword.Text;
            string position = comboboxposition.Text;

            string connectionString = "Data Source=DESKTOP-6H7B0F7;Initial Catalog=SWHospital;Integrated Security=True";

            string query = "";
            string message = "";

            switch (position)
            {
                case "Patient":
                    query = "SELECT COUNT(*) FROM Patient WHERE Patient_ID = @userId AND Password = @password";
                    message = "Login Successful";
                    break;
                case "Doctor":
                    query = "SELECT COUNT(*) FROM Doctor WHERE Doctor_ID = @userId AND Password = @password";
                    message = "Login Successful";
                    break;
                case "Admin":
                    query = "SELECT COUNT(*) FROM Admin_Info WHERE Admin_ID = @userId AND Password = @password";
                    message = "Login Successful";
                    break;
                default:
                    MessageBox.Show("Please select a valid position");
                    return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    if (count == 1)
                    {
                        MessageBox.Show(message);
                    }
                    else
                    {
                        MessageBox.Show("Login failed. You are not a registered {position}.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: {ex.Message}");
            }

        }
    }
}
