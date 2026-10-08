using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardPictureboxBack_Click(object sender, EventArgs e)
        {
            cardPictureboxBack.Visible = true;
            cardPictureBoxFace.Visible = false;
        }

        private void showFaceButton_Click(object sender, EventArgs e)
        {
            cardPictureboxBack.Visible = false;
            cardPictureBoxFace.Visible = true;

        }

        private void showBackButton_Click(object sender, EventArgs e)
        {
            cardPictureboxBack.Visible = true;
            cardPictureBoxFace.Visible = false;
        }
    }
}
