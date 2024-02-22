namespace LIstForm
{
    public partial class Form1 : Form
    {
        List<string> stringList;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            stringList = new List<string>();
        }

        private void btnAddStringToList_Click(object sender, EventArgs e)
        {
            stringList.Add(txtStringToBeAdded.Text);
            txtStringToBeAdded.Text = "";
        }

        private void btnSearchFromList_Click(object sender, EventArgs e)
        {
            cbStringList.Items.Clear();
            foreach (string str in stringList)
            {
                cbStringList.Items.Add(str);
            }
        }
    }
}