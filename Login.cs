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
    public partial class Login : Form
    {
        public static Login instance;
        int authPin(int ID, int pin)
        {
            for (int i = 0; i < id.Length; i++)
            {
                if (ID == id[i] && pin == pins[i])
                {
                    return i;
                }
            }
            return -1;
        }

        int[] id = { 123, 124, 125, 126, 127 };
        int[] pins = { 111, 222, 333, 444, 555 };
        public double[] accBal = { 10000.0, 20000.0, 15000.0, 30000.0, 25000.0 };
        int attempts = 3;
        public int authenticate;
        public Login()
        {
            InitializeComponent();
            instance = this;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(AccNum.Text);
            int pin = int.Parse(Pin.Text);


            authenticate = authPin(ID, pin);
            if (attempts > 0)
            {
                if (authenticate != -1)
                {
                    this.Hide();
                    Home h = new Home();
                    h.Show();
                }
                else
                {
                    attempts--;
                    MessageBox.Show("INVALID ID OR PIN. Attempts remaining: " + attempts);
                }
            }
            
            if (attempts == 0) {
                MessageBox.Show("NO MORE ATTEMPTS. \nENTER ADMIN PIN TO UNBLOCK THE SERVICE");
                this.Hide();
                adminpin a1 = new adminpin();
                a1.Show();
            }


            void textBox2_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
}