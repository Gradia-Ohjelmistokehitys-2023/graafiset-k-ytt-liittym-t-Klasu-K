namespace DictionaryForms
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> stringDictionary;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeDictionary_Click(object sender, EventArgs e)
        {
            stringDictionary = new Dictionary<string, string>();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            stringDictionary.Add(txtKey.Text, txtValue.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblValue.Text = stringDictionary[txtSearchKey.Text];
        }
    }
}