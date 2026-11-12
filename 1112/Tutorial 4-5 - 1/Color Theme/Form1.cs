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
        const int YELLOW = 1; // 定義常數 YELLOW，值為 1。
        const int RED = 2;
        const int WHITE = 3; // 定義常數 WHITE，值為 3。
        const int NORMAL = 4;

        private int colorChoice; // 宣告一個 colorChoice 變數，用於存儲顏色選擇。 
        public Form1()
        {
            // 初始化表單上的所有元件。
            InitializeComponent();
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            colorChoice = YELLOW; // 將 colorChoice 設置為 YELLOW。
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            colorChoice = RED; // 將 colorChoice 設置為 RED。
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            colorChoice = WHITE; // 將 colorChoice 設置為 WHITE。
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            colorChoice = NORMAL; // 將 colorChoice 設置為 NORMAL。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (colorChoice)
            {
                case YELLOW:
                    this.BackColor = Color.Yellow;
                    break;
                case RED:
                    this.BackColor = Color.Red;
                    break;
                case WHITE:
                    this.BackColor = Color.White;
                    break;
                case NORMAL:
                    this.BackColor = SystemColors.Control;
                    break;
            }
        }
    } }
