using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = colorDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            { 
                //BackColor = colorDialog1.Color;
                button1.BackColor = colorDialog1.Color;
            }
        }
    }
}
