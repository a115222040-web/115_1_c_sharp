using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            const decimal MIN_SALARY = 30000m; // 最低薪資要求
            const int MIN_YEARS = 2; // 最低工作年資要求

            decimal salary;
            int yearsOnjob;

            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("薪資格式錯誤，請輸入數值。", "輸入錯誤");
                salaryTextBox.Focus();
                return;
            }

            try
            {
                yearsOnjob = int.Parse(yearsTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("工作年資格式錯誤，請輸入數值。", "輸入錯誤");
                yearsTextBox.Focus();
                return;

            }

            if (salary >= MIN_SALARY && yearsOnjob >= MIN_YEARS)
            {
                decisionLabel.Text = "符合貸款資格";
            }
            else
            {
                decisionLabel.Text = "不符合貸款資格";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除文字輸入框與貸款審核結果。
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將焦點移回薪資輸入框。
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
