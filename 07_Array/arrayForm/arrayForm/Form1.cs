namespace arrayForm
{
    public partial class Form1 : Form
    {
        int[] savedNumbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuoTaulukko_Click(object sender, EventArgs e)
        {
            try
            {
                int arraySize = int.Parse(txtTaulukonKoko.Text);
                savedNumbers = new int[arraySize];
            }
            catch
            {
                MessageBox.Show("taulukon koko-kenttä ei ole sopiva");
            }
        }

        private void btnTalleta_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(txtTalletettavanIndeksi.Text);
                int number = int.Parse(txtTalletettavaNumero.Text);
                savedNumbers[index] = number;
            }
            catch
            {
                MessageBox.Show("numeroa ei voitu tallettaa, ovatko syöttämäsi arvot numeroita ja oletko jo luonut taulukon?");
            }

        }

        private void btnHae_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(txtTalletuspaikanHakuIndeksi.Text);
                int loadedNumber = savedNumbers[index];
                labelLadattuNumero.Text = loadedNumber.ToString();
            }
            catch
            {
                MessageBox.Show("numeroa ei voitu ladata,onko indexi varmasti numero ja onko indexin sijaintiin varmasti talletettu jotain?");
            }
        }
    }
}