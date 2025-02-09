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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DEPOSIT d1 = new DEPOSIT();
            d1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            balance b1 = new balance();
            b1.Show();
        }

        private void withbtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            withdraw w1 = new withdraw();
            w1.Show();
        }

        private void fastbtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fastcach f1 = new fastcach();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l2 = new Login();
            l2.Show();
        }
    }
}
