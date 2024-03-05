using System.Diagnostics;
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

        private bool calculate()
        {
            int number = 0;
            int indexOfLastChar = 0;
            Debug.WriteLineIf(getNextNumbers(0, ref number, ref indexOfLastChar), number);
            return true;
        }

        private bool getNextNumbers(int startIndex, ref int number, ref int indexOfLastChar)
        {
            string characters = txtDisplay.Text.Substring(startIndex);


            int numberAmount = 0;
            bool onlyValidNumbersFound = true;
            while (onlyValidNumbersFound && numberAmount < characters.Length) {
                if (char.IsDigit(characters, numberAmount)) {                    
                    numberAmount++;
                }
                else {
                    onlyValidNumbersFound = false;
                }
            }
            if (numberAmount > 0) {
                indexOfLastChar = startIndex + numberAmount;
                number = int.Parse(txtDisplay.Text.Substring(0, numberAmount));
                return true;
            }

            return false;
        }

        private bool getNextOperation(int startIndex, ref char character, ref int indexOfLastChar)
        {
            string characters = txtDisplay.Text.Substring(startIndex);

            return true;
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
            if(txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }      
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            calculate();
        }
    }
}