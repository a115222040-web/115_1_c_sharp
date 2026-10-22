using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the test scores.
                double test1 = double.Parse(test1TextBox.Text);
                double test2 = double.Parse(test2TextBox.Text);
                double test3 = double.Parse(test3TextBox.Text);

                // Calculate the average.
                double average = (test1 + test2 + test3) / 3;

                // Display the average.
                averageLabel.Text = average.ToString("F1");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric test scores.", "Input Error");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the input and output controls.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
