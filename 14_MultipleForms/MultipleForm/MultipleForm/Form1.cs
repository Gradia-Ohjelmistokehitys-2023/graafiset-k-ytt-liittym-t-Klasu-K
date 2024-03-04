namespace MultipleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            SecondaryForm secondaryForm = new SecondaryForm();
            secondaryForm.SecondaryFormData = txtSecondaryformDataInput.Text;
            secondaryForm.Show();
        }
    }
}