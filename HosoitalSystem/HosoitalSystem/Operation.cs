using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HosoitalSystem
{
    public partial class Operation : Form
    {
        public Operation()
        {
            InitializeComponent();

        }

        private void Operation1_Click(object sender, EventArgs e)
        {
            Operation1 Operation1 = new Operation1();
            Operation1.Show();
            this.Hide();
        }

        private void Operation3_Click(object sender, EventArgs e)
        {
            Operation3 Operation3 = new Operation3();
            Operation3.Show();
            this.Hide();

        }

        private void Operation2_Click(object sender, EventArgs e)
        {
            Operation2 Operation2 = new Operation2();
            Operation2.Show();
            this.Hide();
        }
    }
}
