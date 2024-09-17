using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messegeBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do u want to exit the application", "Information",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
