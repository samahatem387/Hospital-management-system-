
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
    public partial class ManageDoctor : Form
    {
        private string connectionString = "Data Source=DESKTOP-6H7B0F7;Initial Catalog=SWHospital;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder commandBuilder;
        private DataTable table;

        public ManageDoctor()
        {
            InitializeComponent();
            LoadDoctors();

        }
          private void ClearDoctorFields()
        {
            txtdoctorname.Text = "";
            txtdoctorid.Text = "";
            txtdoctorpassword.Text = "";
            txtdoctornumber.Text = "";
            txtdoctoremail.Text = "";
            txtdoctorgender.Text = "";
            txtdoctorspeciality.Text = "";
            dateTimePicker1.Value = DateTime.Today;
        }

        private void ADD_Click(object sender, EventArgs e)
        {
              // Code to add a new doctor to the table
            string doctorName = txtdoctorname.Text;
            string doctorPassword = txtdoctorpassword.Text;
            string doctorPhoneNumber = txtdoctornumber.Text;
            string Doctoremail = txtdoctoremail.Text;
            string Doctor_ID = txtdoctorid.Text;
            string doctorGender = txtdoctorgender.Text;
            string doctorSpecialty = txtdoctorspeciality.Text;
            DateTime doctorDOB = dateTimePicker1.Value;

            string query = "INSERT INTO Doctor (Doctor_ID, Name, Gender, Birthdate, Specialty, Phone_number, Email, Password) VALUES (@Doctor_ID, @Name, @Gender, @Birthdate, @Specialty, @Phone_number, @Email, @Password)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", doctorName);
                    command.Parameters.AddWithValue("@Password", doctorPassword);
                    command.Parameters.AddWithValue("@Phone_number", doctorPhoneNumber);
                    command.Parameters.AddWithValue("@Email", Doctoremail);
                    command.Parameters.AddWithValue("@Doctor_ID", Doctor_ID);
                    command.Parameters.AddWithValue("@Gender", doctorGender);
                    command.Parameters.AddWithValue("@Birthdate", doctorDOB);
                    command.Parameters.AddWithValue("@Specialty", doctorSpecialty);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Doctor added successfully.");
                        ClearDoctorFields();
                    }
                    else
                    {
                        MessageBox.Show("Unable to add doctor.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: {ex.Message}");
            }

            // Reload the doctor records in the DataGridView
            LoadDoctors();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
             if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected records?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            // Create a data adapter for the Doctor table
                            dataAdapter = new SqlDataAdapter("SELECT * FROM Doctor", connection);

                            // Create a SqlCommandBuilder to generate the insert, update, and delete commands
                            commandBuilder = new SqlCommandBuilder(dataAdapter);

                            // Set the delete command for the data adapter
                            dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();

                            // Get the selected rows and delete them from the data adapter
                            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                            {
                                int doctorId = (int)row.Cells["Doctor_ID"].Value;

                                // Delete the row from the data adapter
                                DataRow[] rowsToDelete = table.Select("Doctor_ID = {doctorId}");
                                rowsToDelete[0].Delete();
                            }

                            // Update the changes to the database
                            dataAdapter.Update(table);

                            // Reload the doctors in the DataGridView
                            LoadDoctors();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select at least one record to delete.");
            }
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            
            Admin Admin = new Admin();
            Admin.Show();
            this.Hide();

        }
        
        private void LoadDoctors()
        {
            try
            {
                string query = "SELECT * FROM Doctor";
                dataAdapter = new SqlDataAdapter(query, connectionString);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: {ex.Message}");
            }
        }
        private void ManageDoctor_Load(object sender, EventArgs e)
        {
            LoadDoctors();

        }
    }
}
