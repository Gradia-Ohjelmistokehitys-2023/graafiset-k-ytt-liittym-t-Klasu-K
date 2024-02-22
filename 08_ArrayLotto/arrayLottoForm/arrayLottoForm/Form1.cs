namespace arrayLottoForm
{
    public partial class Form1 : Form
    {
        int[] lotteryNumbers = new int[7];
        int[] bonusLotteryNumbers = new int[2];
        int rightNumbersAmount;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtUserNumbers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rightNumbersAmount = 0;
                string[] userNumberString = txtUserNumbers.Text.Split(",");
                int[] userNumbers = Array.ConvertAll(userNumberString, int.Parse);
                int[] allWinningNumbers = lotteryNumbers.Concat(bonusLotteryNumbers).ToArray();
                foreach (var userNumber in userNumbers)
                {
                    foreach (var winningNumber in allWinningNumbers)
                    {
                        if (userNumber == winningNumber)
                        {
                            rightNumbersAmount += 1;
                            break;
                        }
                    }
                }
                labelCorrectNumbersAmount.Text = rightNumbersAmount.ToString();
            }
            catch
            {
                labelCorrectNumbersAmount.Text = "0";
            }
        }

        private void btnDrawNumbers_Click(object sender, EventArgs e)
        {
            int[] remainingNumbers = new int[40];
            for (int i = 0; i < 40; i++)
            {
                remainingNumbers[i] = i + 1;
            }
            for (int i = 0; i < 7; i++)
            {
                lotteryNumbers[i] = drawNumberFromList(ref remainingNumbers);
            }
            for (int i = 0; i < 2; i++)
            {
                bonusLotteryNumbers[i] = drawNumberFromList(ref remainingNumbers);
            }
            labelNumbers.Text = string.Join(",", lotteryNumbers);
            labelBonusNumbers.Text = string.Join(",", bonusLotteryNumbers);
            int[] sortedNumbers = lotteryNumbers;
            Array.Sort(sortedNumbers);
            labelNumbersOrdered.Text = string.Join(",", sortedNumbers);
        }

        int drawNumberFromList(ref int[] numbers)
        {
            int index = rnd.Next(0, numbers.Length);
            int number = numbers[index];
            numbers = numbers.Where((val, idx) => index != idx).ToArray();
            return number;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}