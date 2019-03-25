using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double SR1 = double.Parse(textBox1.Text);
            double SR2 = double.Parse(textBox2.Text);
            double SR3 = double.Parse(textBox3.Text);
            double SR4 = double.Parse(textBox4.Text);
            double SR5 = double.Parse(textBox5.Text);
        }
    }
}
