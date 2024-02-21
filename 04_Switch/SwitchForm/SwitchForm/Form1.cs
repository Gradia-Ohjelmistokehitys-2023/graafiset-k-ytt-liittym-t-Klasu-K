namespace SwitchForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MouseClick(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "valinta1":
                    MessageBox.Show("valinta1", "huom");
                    break;
                case "valinta2":
                    MessageBox.Show("valinta2", "huom");
                    break;
                case "valinta3":
                    MessageBox.Show("valinta3", "huom");
                    break;
                case "valinta4":
                    MessageBox.Show("valinta4", "huom");
                    break;

                default:
                    MessageBox.Show("Default", "huom");
                    break;
            }
        }
    }
}