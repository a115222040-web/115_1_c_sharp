namespace StringCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compareButton_Click(object? sender, EventArgs e)
        {
            string string1, string2;
                string1 = string1TextBox.Text;
                string2 = string2TextBox.Text;
            if ( string.Compare(string1, string2) == 0)
            {
                MessageBox.Show("字串相同");


            }
            else if (string.Compare(string1, string2) < 0)
            {
                MessageBox.Show("字串1小於字串2");
            }
            else
            {
                MessageBox.Show("字串1大於字串2");
            }



        }

        private void exitButton_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
