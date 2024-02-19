
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
    public partial class Operation3 : Form
    {
        public Operation3()
        {
            InitializeComponent();
        }

        private void Operation3_Load(object sender, EventArgs e)
        {

            // Initialize the connection
            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

            // Open the connection
            conn.Open();

            // Create a SELECT query
            string query = "SELECT * FROM Medical_Record";

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

        private void back_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            Main.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            // Validate that the Record_ID textbox contains only numbers
            if (!Regex.IsMatch(Record_ID.Text, @"^\d+$"))
            {
                MessageBox.Show("Record ID should only contain numbers.");
                return;
            }

            // Get the Record_ID of the selected row
            int record_Id = int.Parse(Record_ID.Text);

            // Initialize the connection
            SqlConnection conn = new SqlConnection("Data Source=desktop-6h7b0f7;Initial Catalog=Sama'sHospital;Integrated Security=True");

            // Open the connection
            conn.Open();

            // Create a DELETE query
            string query = "DELETE FROM Medical_Record WHERE Record_ID = @record_Id";

            // Create a SqlCommand object with the query and connection object
            SqlCommand cmd = new SqlCommand(query, conn);

            // Add parameter values to the SqlCommand object
            cmd.Parameters.AddWithValue("@record_Id", record_Id);

            // Execute the query
            int result = cmd.ExecuteNonQuery();

            // If the query was successful
            if (result > 0)
            {
                MessageBox.Show("Record deleted successfully!");

                // Remove the selected row from the DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Record not deleted!");
            }

            // Close the connection
            conn.Close();
        }

        private void Record_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
