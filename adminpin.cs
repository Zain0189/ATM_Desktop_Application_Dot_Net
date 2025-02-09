using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class adminpin : Form
    {
        public adminpin()
        {
            InitializeComponent();
        }

        private void Pin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lgout1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            int admpin = int.Parse(admintxt.Text);
            if (admpin == 2003)
            {
                this.Hide();
                Login l2 = new Login();
                l2.Show();
            }
            else
            {
                MessageBox.Show("WRONG ADMIN PIN.");
            }
        }
    }
}
