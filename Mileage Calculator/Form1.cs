using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mileage_Calculator
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled, amountOwed;
        double reimburseRate = 0.39;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveld");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
            if (startingMileage > endingMileage)
            {
                MessageBox.Show("The starting mileage must be less than the ending milage","Cannot Calculate Mileage");
                return;
            }
            else
            {
                milesTraveled = endingMileage -startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
        }
    }
}
