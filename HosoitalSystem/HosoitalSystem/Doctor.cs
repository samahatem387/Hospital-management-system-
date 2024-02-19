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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Doctor_ID = doctorTextBox.Text;
            string name = nameTextBox.Text;
            string specialty = specialtyTextBox.Text;
            string Phone_number = numberTextBox.Text;
            string Email = emailTextBox.Text;
            string gender = genderTextBox.Text;




            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");


            conn.Open();

            string query = "INSERT INTO Doctor (Doctor_ID, Name,Specialty ,Phone_number, Email, Gender) VALUES (@doctor_ID, @name,@specialty,@phone_number,@email, @gender)";

           
            SqlCommand cmd = new SqlCommand(query, conn);

       
            cmd.Parameters.AddWithValue("@doctor_ID", Doctor_ID);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@specialty", specialty);
            cmd.Parameters.AddWithValue("@phone_number", Phone_number);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@gender", gender);

            int result = cmd.ExecuteNonQuery();


            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Doctor", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        
            conn.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            Main.Show();
            this.Hide();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string doctorId = dataGridView1.CurrentRow.Cells["Doctor_ID"].Value.ToString();


            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

            // Open the connection
            conn.Open();

            // Create a DELETE query
            string query = "DELETE FROM Doctor WHERE Doctor_ID = @doctorId";

            // Create a SqlCommand object with the query and connection object
            SqlCommand cmd = new SqlCommand(query, conn);

            // Add parameter values to the SqlCommand object
            cmd.Parameters.AddWithValue("@doctorId", doctorId);

            // Execute the query
            int result = cmd.ExecuteNonQuery();

            // If the query was successful
            if (result > 0)
            {
                MessageBox.Show("Record deleted successfully!");

                // Refresh the DataGridView
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Doctor", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Record not deleted!");
            }

           
            conn.Close();
        }

        private void Doctor_Load_Click(object sender, EventArgs e)
        {

    SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

   
    conn.Open();

 
    string query = "SELECT * FROM Doctor";

    SqlCommand cmd = new SqlCommand(query, conn);

    SqlDataAdapter sda = new SqlDataAdapter(cmd);

    DataTable dt = new DataTable();

    sda.Fill(dt);

    dataGridView1.DataSource = dt;

    
    conn.Close();


        }

        private void doctorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void specialtyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
