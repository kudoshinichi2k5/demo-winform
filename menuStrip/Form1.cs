using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("The file is opened");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("The file is saved");
            }
        }
    }
}
