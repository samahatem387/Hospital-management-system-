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
    public partial class ManagePatient : Form
    {
        private string connectionString = "Data Source=DESKTOP-6H7B0F7;Initial Catalog=SWHospital;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder commandBuilder;
        private DataTable table;


        public ManagePatient()
        {
            InitializeComponent();
            LoadPatients();

        }
        private void LoadPatients()
        {
            try
            {
                string query = "SELECT * FROM Patient";
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

        private void ADD_Click(object sender, EventArgs e)
        {
             // Code to add a new patient to the table
            string patientName = txtPatientName.Text;
            string patientPassword = txtpassword.Text;
            string patientPhoneNumber = txtPatientPhoneNumber.Text;
            string Patient_ID = txtPatientid.Text;
            string patientGender = txtPatientGender.Text;
            DateTime patientDOB = dtpPatientDOB.Value;

            string query = "INSERT INTO Patient (Patient_ID, Name, Gender, Birthdate, Phone, Password) VALUES (@Patient_ID, @Name, @Gender, @Birthdate, @Phone, @Password)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", patientName);
                    command.Parameters.AddWithValue("@Password", patientPassword);
                    command.Parameters.AddWithValue("@Phone", patientPhoneNumber);
                    command.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                    command.Parameters.AddWithValue("@Gender", patientGender);
                    command.Parameters.AddWithValue("@Birthdate", patientDOB);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patient added successfully.");
                        ClearPatientFields();
                    }
                    else
                    {
                        MessageBox.Show("Unable to add patient.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: {ex.Message}");
            }

            // Reload the patient records in the DataGridView
            LoadPatients();
        }
         private void ClearPatientFields()
        {
            txtPatientName.Text = "";
            txtpassword.Text = "";
            txtPatientPhoneNumber.Text = "";
            txtPatientid.Text = "";
            txtPatientGender.Text = "";
            dtpPatientDOB.Value = DateTime.Today;
        }


        private void DELETE_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected records?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int patientId = (int)row.Cells["Patient_ID"].Value;

                        try
                        {
                            string query = "DELETE FROM Patient WHERE Patient_ID = @patientId";
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                SqlCommand command = new SqlCommand(query, connection);
                                command.Parameters.AddWithValue("@patientId", patientId);
                                connection.Open();
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: {ex.Message}");
                        }
                    }

                    // Reload the patient records in the DataGridView
                    LoadPatients();
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

        private void ManagePatient_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }
    }
}
