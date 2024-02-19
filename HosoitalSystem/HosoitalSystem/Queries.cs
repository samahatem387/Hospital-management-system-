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
    public partial class Queries : Form
    {
        public Queries()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            Main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");
            string specialty = textBox1.Text;
            string query4 = "SELECT Name FROM Doctor WHERE Specialty = @Specialty";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query4, connection);
                command.Parameters.AddWithValue("@Specialty", specialty);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "DoctorWithSpecialty");
                dataGridView1.DataSource = dataSet.Tables["DoctorWithSpecialty"];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True";
            string gender = textBox2.Text;
            string query = "SELECT Name FROM Patient WHERE Gender = @Gender";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Gender", gender);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "PatientWithGender");
                dataGridView2.DataSource = dataSet.Tables["PatientWithGender"];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True";
            string diagnosis = "High Blood Pressure";
            string query = @"SELECT P.Patient_ID, P.Insurance_ID, I.Name AS Insurance_Company, M.Treatment                 FROM Patient P                 JOIN Medical_Record M ON P.Patient_ID = M.Patient_ID                 JOIN Insurance I ON P.Insurance_ID = I.Insurance_ID                 WHERE M.Diagnosis = @Diagnosis";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Diagnosis", diagnosis);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "PatientsWithHighBP");
                dataGridView3.DataSource = dataSet.Tables["PatientsWithHighBP"];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True";
            string doctorName = textBox3.Text;
            string startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string insuranceProvider = textBox4.Text;

            string query = "SELECT MR.Treatment, P.Patient_ID, P.Insurance_ID, I.Name AS InsuranceProvider " +
                            "FROM Medical_Record MR " +
                            "JOIN Patient P ON P.Patient_ID = MR.Patient_ID " +
                            "JOIN Doctor D ON D.Doctor_ID = MR.Doctor_ID " +
                            "JOIN Insurance I ON I.Insurance_ID = P.Insurance_ID " +
                            "WHERE D.Name = @DoctorName " +
                            "AND MR.Date BETWEEN @StartDate AND @EndDate " +
                            "AND I.Name = @InsuranceProvider";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorName", doctorName);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);
                command.Parameters.AddWithValue("@InsuranceProvider", insuranceProvider);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "MedicalRecords");
                dataGridView4.DataSource = dataSet.Tables["MedicalRecords"];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True";
            string query = "SELECT P.Name, COUNT(M.Record_ID) AS Total_Medical_Records " +
                           "FROM Patient P " +
                           "LEFT JOIN Medical_Record M ON P.Patient_ID = M.Patient_ID " +
                           "GROUP BY P.Name;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "MedicalRecordsPerPatient");
                dataGridView5.DataSource = dataSet.Tables["MedicalRecordsPerPatient"];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True";
            string query = "SELECT AVG(DATEDIFF(YEAR, Birthdate, GETDATE())) AS AvgAge FROM Patient";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Open the connection
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "AverageAge");
                dataGridView6.DataSource = dataSet.Tables["AverageAge"];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True";
            string query = @"SELECT *                FROM Patient p                WHERE NOT EXISTS (                    SELECT 1                    FROM Medical_Record m                    WHERE m.Patient_ID = p.Patient_ID                )";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "PatientsWithNoMedicalRecord");
                    dataGridView7.DataSource = dataSet.Tables["PatientsWithNoMedicalRecord"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            nextquery nextquery = new nextquery();
            nextquery.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}