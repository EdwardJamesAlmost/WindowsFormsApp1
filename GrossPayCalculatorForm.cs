using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GrossPayCalculatorForm : Form
    {
        public GrossPayCalculatorForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee's Gross Pay is: $" + 
                String.Format("{0:C4}",Convert.ToString(Convert.ToDouble(Convert.ToInt32(payCycleLengthTextBox.Text) * 
                Convert.ToInt32(hoursWorkedTextBox.Text) * 
                Convert.ToDouble(hourlyRateTextBox.Text)))));
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
