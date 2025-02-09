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
    public partial class balance : Form
    {
        int index;
        public balance()
        {
            InitializeComponent();
        }

        private void balance_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l5 = new Login();
            l5.Show();
        }

        private void chbalbtn_Click(object sender, EventArgs e)
        {
            double[] accBal = Login.instance.accBal;
            index = Login.instance.authenticate;
            baltxt.Text = accBal[index].ToString();
        }

        private void backbtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h12 = new Home();
            h12.Show();
        }
    }
}
