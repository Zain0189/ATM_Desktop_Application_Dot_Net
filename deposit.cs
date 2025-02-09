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
    public partial class DEPOSIT : Form
    {
        int index;
        public DEPOSIT()
        {
            InitializeComponent();
        }

        private void depbtn2_Click(object sender, EventArgs e)
        {
            double[] accBal = Login.instance.accBal;
            index = Login.instance.authenticate;
            int deposit = int.Parse(deptxt1.Text);
            if(deposit >= 0) 
            {
                accBal[index] = accBal[index] + deposit;
                MessageBox.Show("AMOUNT DEPOSITED SUCCESSFULLY. NEW BALANCE = " + accBal[index]);
            }
            else
            {
                MessageBox.Show("AMOUNT CANNOT BE NEGATIVE.");
            }
        }

        private void lgout2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l2 = new Login();
            l2.Show();
        }

        private void deptxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DEPOSIT_Load(object sender, EventArgs e)
        {

        }

        private void backbtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h11 = new Home();
            h11.Show();
        }
    }
}
