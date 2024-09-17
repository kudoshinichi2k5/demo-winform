using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBox
{
    public partial class Form1 : Form
    {
        private int counter = 3;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Item " + counter);
            counter++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
            comboBox2.Items.Remove(comboBox2.SelectedItem);
        }
    }
}
