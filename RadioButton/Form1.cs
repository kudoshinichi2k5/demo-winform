using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label1.Text = "radioButton1 is checked";
            else if (radioButton2.Checked)
                label1.Text = "radioButton2 is checked";
            else if (radioButton3.Checked)
                label1.Text = "radioButton3 is checked";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }
    }
}
