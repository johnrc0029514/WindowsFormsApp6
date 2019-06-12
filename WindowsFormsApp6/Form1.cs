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
            try
            {
                // i put the try catch in for an error message to be displayed when a letter is put into a resistor value box 
                // i used double in order to set the value of each text box
                double SR1 = double.Parse(textBox2.Text);
                double SR2 = double.Parse(textBox3.Text);
                double SR3 = double.Parse(textBox4.Text);
                double SR4 = double.Parse(textBox5.Text);
                double SR5 = double.Parse(textBox6.Text);

                // below shows the formula i used in order for the series calculation to be complete 
                double TotalResistance = SR1 + SR2 + SR3 + SR4 + SR5;
                // below is the code i used for the total resistance to show up afte it has been calculated 
                MessageBox.Show("TotalResistance = " + TotalResistance.ToString("0.00") + "Ω");
            }

            catch
            {
                // below is the message that would show up for the error message
                MessageBox.Show("Error in inputting values.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //i used the try catch method once again to display an error message if a letter was put in a ressistor value box 
                // below here, i used double to assign each text box a resistor value
                double PR1 = double.Parse(textBox7.Text);
                double PR2 = double.Parse(textBox8.Text);
                double PR3 = double.Parse(textBox9.Text);
                double PR4 = double.Parse(textBox10.Text);
                double PR5 = double.Parse(textBox1.Text);

                //below is the formula i used in order for this calculation to be complete. it is similar to the series calculation
                double TotalResistance = (1.0 / (1.0 / PR1 + 1.0 / PR2 + 1.0 / PR3 + 1.0 / PR4 + 1.0 / PR5));
                // the code below will display the answer for an calculation 
                MessageBox.Show("TotalResistance = " + TotalResistance.ToString("0.00") + "Ω");
            }

            catch
            {
                MessageBox.Show("Error in inputting values.");
            }
        }
    }
}








