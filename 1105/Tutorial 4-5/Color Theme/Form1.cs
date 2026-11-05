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
            // 處理選取黃色背景的事件。
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // 處理選取紅色背景的事件。
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // 處理選取白色背景的事件。
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // 處理恢復預設背景色的事件。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
