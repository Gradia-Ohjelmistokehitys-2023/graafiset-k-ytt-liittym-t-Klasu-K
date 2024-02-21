namespace whileForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool continueLoop = true;
            while (continueLoop)
            {
               DialogResult results = MessageBox.Show("jatketaanko looppia", "Huom!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               continueLoop = results == DialogResult.Yes;
            }
        }
    }
}