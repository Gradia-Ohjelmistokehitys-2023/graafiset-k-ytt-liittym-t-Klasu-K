using Microsoft.VisualBasic;

namespace forForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int roundNumber))
            {
                for (int i = 1; i <= roundNumber; i++)
                {
                    labelNumber.Text = i.ToString();
                    Update();
                    Thread.Sleep(100);
                }
            }
            else
            {
                MessageBox.Show("not valid number");
            }
        }
    }
}