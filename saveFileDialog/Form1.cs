using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //string fileName = openFileDialog1.FileName;
                //textBox1.Text = System.IO.File.ReadAllText(fileName);
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(fileName, textBox1.Text);
            }
        }
    }
}
