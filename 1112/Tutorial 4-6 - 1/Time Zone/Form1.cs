using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
           if (cityListBox.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇一個城市。", "錯誤");
                return;
            }
            string selectedCity = cityListBox.SelectedItem.ToString();
            string timeZone = "";
            switch (selectedCity)
            {
                case "丹佛":
                    timeZone = "Mountain Time Zone";
                    break;
                case "檀香山":
                    timeZone = "Hawaii-Aleutian Time Zone";
                    break;
                case "明尼阿波利斯":
                    timeZone = "Central Time Zone";
                    break;
                case "紐約":
                    timeZone = "Eastern Time Zone";
                    break;
                case "舊金山":
                    timeZone = "Pacific Time Zone";
                    break;
            }
            timeZoneLabel.Text = $"所選城市的時區是：{timeZone}";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void cityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityListBox.SelectedIndex = cityListBox.SelectedIndex;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cityListBox.SelectedIndex = 0;
        }
    }
}
