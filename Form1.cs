using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckSpeedCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double speed = 0;

            // Get the wind speed from the user. 
            double windSpeed = Convert.ToDouble(textBox1.Text);

            // Calculate the speed of the duck in a tailwind. 
            speed = (2 * windSpeed) + 15;

            // Display the result to the user. 
            lblResult.Text = "The speed of a duck in a tailwind is " + speed + " mph.";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {   // Clear all text boxes and labels when the clear button is clicked. 

            textBox1.Clear();

            lblResult.Text = "";

        }

    }// end class 
}// end 
