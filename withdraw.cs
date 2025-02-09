using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class withdraw : Form
    {
        int index;
        public withdraw()
        {
            InitializeComponent();
        }

        private void withdraw_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l4 = new Login();
            l4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] accBal = Login.instance.accBal;
            index = Login.instance.authenticate;
            double wDAmount = double.Parse(wthdrawtxt1.Text);
            if (wDAmount >= 0)
            {
                if (accBal[index] < wDAmount)
                {
                    MessageBox.Show("NOT ENOUGH AMOUNT.");
                }
                else
                {
                    accBal[index] = accBal[index] - wDAmount;
                    MessageBox.Show("AMOUNT WITHDRAWAL SUCCESSFULL. NEW BALANCE = " + accBal[index]);
                }
            }
            else
            {
                MessageBox.Show("AMOUNT CANNOT BE NEGATIVE.");
            }
        }

        private void backbtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h14 = new Home();
            h14.Show();
        }
    }
}
