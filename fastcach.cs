using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class fastcach : Form
    {
        public static fastcach instance;
        int index;

        public fastcach()
        {
            InitializeComponent();
            instance = this;
        }

        private void fastcach_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] accBal = Login.instance.accBal;
            index = Login.instance.authenticate;
            if (accBal[index] < 500)
            {
                MessageBox.Show("NOT ENOUGH AMOUNT.");
            }
            else
            {
                accBal[index] = accBal[index] - 500;
                MessageBox.Show("AMOUNT WITHDRAWAL SUCCESSFULL. NEW BALANCE = " + accBal[index]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] accBal = Login.instance.accBal;
            index = Login.instance.authenticate;
            if (accBal[index] < 1000)
            {
                MessageBox.Show("NOT ENOUGH AMOUNT.");
            }
            else
            {
                accBal[index] = accBal[index] - 1000;
                MessageBox.Show("AMOUNT WITHDRAWAL SUCCESSFULL. NEW BALANCE = " + accBal[index]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] accBal = Login.instance.accBal;
            index = Login.instance.authenticate;
            if (accBal[index] < 2000)
            {
                MessageBox.Show("NOT ENOUGH AMOUNT.");
            }
            else
            {
                accBal[index] = accBal[index] - 2000;
                MessageBox.Show("AMOUNT WITHDRAWAL SUCCESSFULL. NEW BALANCE = " + accBal[index]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double[] accBal = Login.instance.accBal;
            index = Login.instance.authenticate;
            if (accBal[index] < 5000)
            {
                MessageBox.Show("NOT ENOUGH AMOUNT.");
            }
            else
            {
                accBal[index] = accBal[index] - 5000;
                MessageBox.Show("AMOUNT WITHDRAWAL SUCCESSFULL. NEW BALANCE = " + accBal[index]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double[] accBal = Login.instance.accBal;
            index = Login.instance.authenticate;
            if (accBal[index] < 10000)
            {
                MessageBox.Show("NOT ENOUGH AMOUNT.");
            }
            else
            {
                accBal[index] = accBal[index] - 10000;
                MessageBox.Show("AMOUNT WITHDRAWAL SUCCESSFULL. NEW BALANCE = " + accBal[index]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double[] accBal = Login.instance.accBal;
            index = Login.instance.authenticate;
            if (accBal[index] < 25000)
            {
                MessageBox.Show("NOT ENOUGH AMOUNT.");
            }
            else
            {
                accBal[index] = accBal[index] - 25000;
                MessageBox.Show("AMOUNT WITHDRAWAL SUCCESSFULL. NEW BALANCE = " + accBal[index]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l3 = new Login();
            l3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h10 = new Home();
            h10.Show();
        }
    }
}
