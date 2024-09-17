using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace errorProvider
{
    public partial class Form1 : Form
    {
        private string username = "admin";
        private string password = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(username) && textBox2.Text.Equals(password) )
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                MessageBox.Show("Login Success");
            }
            else
            {
                if (!textBox1.Text.Equals(username))
                    errorProvider1.SetError(textBox1, "User name is not correct");
                else
                    errorProvider1.Clear();
                if (!textBox2.Text.Equals(password))
                    errorProvider2.SetError(textBox2, "Password is not correct");
                else
                    errorProvider2.Clear();
            }
        }
    }
}
