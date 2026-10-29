using System;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        private const decimal OvertimeThreshold = 40m;
        private const decimal OvertimeRate = 1.5m;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(hoursWorkedTextBox.Text, out decimal hoursWorked) ||
                !decimal.TryParse(hourlyPayRateTextBox.Text, out decimal hourlyPayRate) ||
                hoursWorked < 0 || hourlyPayRate < 0)
            {
                MessageBox.Show(
                    "請輸入有效的工作時數與每小時薪資。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            decimal regularHours = Math.Min(hoursWorked, OvertimeThreshold);
            decimal overtimeHours = Math.Max(hoursWorked - OvertimeThreshold, 0m);
            decimal grossPay = (regularHours * hourlyPayRate) +
                               (overtimeHours * hourlyPayRate * OvertimeRate);

            grossPayLabel.Text = grossPay.ToString("C2");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hoursWorkedTextBox.Clear();
            hourlyPayRateTextBox.Clear();
            grossPayLabel.Text = string.Empty;
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
