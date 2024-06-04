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
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Med_view Med_view = new Med_view();
            Med_view.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            book_apt book_apt = new book_apt();
            book_apt.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
