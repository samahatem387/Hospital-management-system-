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
    public partial class Register : Form
    {
        private string selectedRole;
      

        public Register()
        {
            InitializeComponent();

            cmbRoles.SelectedIndexChanged += CmbRoles_SelectedIndexChanged;
            cmbRoles.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbRoles.AutoCompleteSource = AutoCompleteSource.ListItems;
            RegistrationForm_Load(this, EventArgs.Empty);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // Add roles to ComboBox
            cmbRoles.Items.Add("Doctor");
            cmbRoles.Items.Add("Patient");
            cmbRoles.Items.Add("Admin");
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



        private void button1_Click(object sender, EventArgs e)
        {
             /*  login login = new login();
                            login.show();
                            this.Hide;*/
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }


    }
}
