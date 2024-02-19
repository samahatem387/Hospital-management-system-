using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HosoitalSystem;

namespace HosoitalSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void doctor_Click(object sender, EventArgs e)
        {
            Doctor Doctor = new Doctor(); 
            Doctor.Show(); 
            this.Hide(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Patient Patient = new Patient();
            Patient.Show();
            this.Hide();
        }

        private void Medical_Records_Click(object sender, EventArgs e)
        {
            Medical_Record Medical_Record = new Medical_Record();
            Medical_Record.Show();
            this.Hide();
        }

        private void DataBase_Click(object sender, EventArgs e)
        {

            Database Database = new Database();
            Database.Show();
            this.Hide();
        }

      
        private void InsuranceCompany_Click(object sender, EventArgs e)
        {
               Insurance_company Insurance_company = new Insurance_company();
            Insurance_company.Show();
            this.Hide();

        }

        private void queries_Click(object sender, EventArgs e)
        {
            Queries Queries = new Queries();
            Queries.Show();
            this.Hide();
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Operation Operation = new Operation();
            Operation.Show();

        }
    }
}
