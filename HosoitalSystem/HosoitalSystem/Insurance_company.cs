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
    public partial class Insurance_company : Form
    {
        public Insurance_company()
        {
            InitializeComponent();
        }

        private void addData_Click(object sender, EventArgs e)
        {

            string Insurance_ID = Insurance_IDTextBox.Text;
            string Name = name.Text;
            string Email = emailTextBox.Text;
            string Address = addressTextBox.Text;

            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

            conn.Open();

            // Create an INSERT query and replace the values with parameters
            string query = "INSERT INTO Insurance (Insurance_ID, Name, Email, Address) VALUES (@insurance_ID, @name,@email,@Address)";

            // Create a SqlCommand object with the query and connection object
            SqlCommand cmd = new SqlCommand(query, conn);

            // Add parameter values to the SqlCommand object
            cmd.Parameters.AddWithValue("@insurance_ID", Insurance_ID);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@Address", Address);

            // Execute the query
            int result = cmd.ExecuteNonQuery();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM  Insurance ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            // Close the connection
            conn.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
           /* Main Main = new Main();
            Main.Show();
            this.Hide();*/
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string Insurance_ID = dataGridView1.CurrentRow.Cells["Insurance_ID"].Value.ToString();

            // Initialize the connection
            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

            // Open the connection
            conn.Open();

            // Create a DELETE query
            string query = "DELETE FROM Insurance WHERE Insurance_ID = @insurance_ID";

            // Create a SqlCommand object with the query and connection object
            SqlCommand cmd = new SqlCommand(query, conn);

            // Add parameter values to the SqlCommand object
            cmd.Parameters.AddWithValue("@insurance_ID", Insurance_ID);

            // Execute the query
            int result = cmd.ExecuteNonQuery();

            // If the query was successful
            if (result > 0)
            {
                MessageBox.Show("Record deleted successfully!");

                // Refresh the DataGridView
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Insurance", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Record not deleted!");
            }

            // Close the connection
            conn.Close();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            // Initialize the connection
            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

            // Open the connection
            conn.Open();

            // Create a SELECT query
            string query = "SELECT * FROM Insurance";

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

        private void Insurance_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADDRESS_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insurance_ID_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EMAIL_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
