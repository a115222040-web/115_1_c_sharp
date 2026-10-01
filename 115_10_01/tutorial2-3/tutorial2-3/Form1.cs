using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buongiorno!";
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            translateLabel.Text = "Buenos dias";

        }

        private void germanyButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Guten Mogen";
        }
    }
}
