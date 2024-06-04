using System;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void patient_Click(object sender, System.EventArgs e)
        {
       ManagePatient ManagePatient = new ManagePatient();
            ManagePatient.Show();
            this.Hide();
        }

        private void doctor_Click(object sender, System.EventArgs e)
        {
            ManageDoctor ManageDoctor = new ManageDoctor();
            ManageDoctor.Show();
            this.Hide();
        }
    }
}


      