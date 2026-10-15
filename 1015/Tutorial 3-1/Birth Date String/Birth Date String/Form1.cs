using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 顯示日期按鈕事件：讀取使用者輸入並在輸出標籤顯示
        private void showDateButton_Click(object sender, EventArgs e)
        {
            string dayOfWeek = dayOfWeekTextBox.Text.Trim();
            string month = monthTextBox.Text.Trim();
            string day = dayOfMonthTextBox.Text.Trim();
            string year = yearTextBox.Text.Trim();

            // 組合輸出字串，簡單格式化
            dateOutputLabel.Text = string.Format("{0} {1} {2}, {3}", dayOfWeek, month, day, year);
        }

        // 清除按鈕事件：清空所有輸入與輸出欄位
        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text = string.Empty;
            monthTextBox.Text = string.Empty;
            dayOfMonthTextBox.Text = string.Empty;
            yearTextBox.Text = string.Empty;
            dateOutputLabel.Text = string.Empty;
        }

        // 結束按鈕事件：關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // dayOfWeekTextBox 的文字變更事件（預留，可用於即時驗證）
        private void dayOfWeekTextBox_TextChanged(object sender, EventArgs e)
        {
            // 目前不做處理，保留以避免 Designer 綁定錯誤
        }
    }
}
