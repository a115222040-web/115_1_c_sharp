using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double liters;
            double km;
            double kmpl;
            km = double.Parse(kmTextBox.Text);
            liters = double.Parse(kmTextBox.Text);
            kmpl = km / liters;
            kmpLabel.Text = kmpl.ToString("f2") + " 公里/公升";
        }   
      
       



        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void milesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void milesPromptLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
