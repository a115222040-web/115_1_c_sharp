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

           if (double.TryParse(kmTextBox.Text, out km) && double.TryParse(literTextBox.Text, out liters))
            {
                
                
                kmpl = km / liters;
                kmpLabel.Text = kmpl.ToString("f2") + " 公里/公升";
            }
            else
            {
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          else
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
