using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Theme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的所有元件。
            InitializeComponent();
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow; // 將表單的背景色設置為黃色。
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red; // 將表單的背景色設置為紅色。
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White; // 將表單的背景色設置為白色。
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           this.Font = new Font(this.Font.FontFamily, 8.25f); // 將表單的字體大小設置為正常大小。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
