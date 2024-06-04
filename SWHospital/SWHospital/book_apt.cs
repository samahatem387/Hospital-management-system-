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

namespace SWHospital
{
    public partial class book_apt : Form
    {
        public book_apt()
        {
            InitializeComponent();

            // Populate the ComboBox with available appointment dates
            comboBox1.Items.AddRange(new object[] {
                "2023-07-15"
            });
        }


        private void Back_Click(object sender, EventArgs e)
        {
            patient patient = new patient();
            patient.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6H7B0F7;Initial Catalog=SWHospital;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Doctor", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

            int patientID = int.Parse(textBox3.Text);
            int doctorID = int.Parse(textBox1.Text);
            string patient_Name = textBox2.Text;
            string appointmentDate = comboBox1.SelectedItem.ToString();
            DateTime appointmentTime = DateTime.Now;

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6H7B0F7;Initial Catalog=SWHospital;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Appointments (Patient_ID,Patient_Name,Doctor_ID, Appointment_Time) " +
                    "VALUES (@PatientID, @Patient_Name,@DoctorID, @AppointmentTime)", connection);
                command.Parameters.AddWithValue("@PatientID", patientID);
                command.Parameters.AddWithValue("@Patient_Name", patient_Name);
                command.Parameters.AddWithValue("@DoctorID", doctorID);
                command.Parameters.AddWithValue("@AppointmentTime", appointmentTime);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                command = new SqlCommand("SELECT * FROM Appointments WHERE Patient_ID = @PatientID", connection);
                command.Parameters.AddWithValue("@PatientID", patientID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable;
            }
        }

    }
}