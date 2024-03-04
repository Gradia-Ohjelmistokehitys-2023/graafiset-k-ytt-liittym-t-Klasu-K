using System.ComponentModel;

namespace DataBindaus
{
    public partial class Form1 : Form
    {
        private BindingList<Person> PersonsList;
        public Form1()
        {
            InitializeComponent();
            PersonsList = new BindingList<Person>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtFirstname.Text == "" || txtLastname.Text == "")
            {
                MessageBox.Show("syötä etunimi ja sukunimi");
            }
            else
            {
                PersonsList.Add(new Person(txtFirstname.Text, txtLastname.Text));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbPersons.DataSource = PersonsList;
            cbPersons.DisplayMember = "LastName";
        }
    }
}