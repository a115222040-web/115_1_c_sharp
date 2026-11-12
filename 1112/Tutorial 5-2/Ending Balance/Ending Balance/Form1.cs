using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            const decimal INTEREST_RATE = 0.005m; // Monthly interest rate of 0.5%

            decimal balance;
                int months;

            if (decimal.TryParse(startingBalTextBox.Text, out balance) &&
                
                int.TryParse(monthsTextBox.Text, out months0))
                {
                    if (balance >= 0 && months >= 0)
                    {
                        // Clear the ListBox.
                        detailListBox.Items.Clear();
                        // Calculate the ending balance and display the details in the ListBox.
                        for (int month = 1; month <= months; month++)
                        {
                            balance += balance * INTEREST_RATE;
                            detailListBox.Items.Add($"Month {month}: {balance:C}");
                        }
                }   

                else
                    {







                   else
                        {
                            MessageBox.Show("Please enter valid numeric values for starting balance and months.");
                        }

                    }
            // Display the ending balance in the Label control.
            endingBalanceLabel.Text = balance.ToString("C");
            }
           




        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes, the endingBalanceLabel control,
            // and the ListBox.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // Reset the focus.
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
