using CalculatorApp.Backend;
namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void addCharacter(char character)
        {
            txtDisplay.AppendText(character.ToString());
        }

        private void btnNumberZero_Click(object sender, EventArgs e)
        {
            addCharacter('0');
        }

        private void btnNumberOne_Click(object sender, EventArgs e)
        {
            addCharacter('1');
        }

        private void btnNumberTwo_Click(object sender, EventArgs e)
        {
            addCharacter('2');
        }

        private void btnNumberThree_Click(object sender, EventArgs e)
        {
            addCharacter('3');
        }

        private void btnNumberFour_Click(object sender, EventArgs e)
        {
            addCharacter('4');
        }

        private void btnNumberFive_Click(object sender, EventArgs e)
        {
            addCharacter('5');
        }

        private void btnNumberSix_Click(object sender, EventArgs e)
        {
            addCharacter('6');
        }

        private void btnNumberSeven_Click(object sender, EventArgs e)
        {
            addCharacter('7');
        }

        private void btnNumberEight_Click(object sender, EventArgs e)
        {
            addCharacter('8');
        }

        private void btnNumberNine_Click(object sender, EventArgs e)
        {
            addCharacter('9');
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            addCharacter('+');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            addCharacter('-');
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            addCharacter('*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            addCharacter('/');
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (Calculator.Calculate(txtDisplay.Text, out float results))
            {
                txtDisplay.Text = results.ToString();
            }
        }
    }
}