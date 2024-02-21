using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace windowsForms
{
    public partial class MyForm : Form
    {

        public MyForm()
        {
            InitializeComponent();
            Dictionary<TextBoxBase, string> defaultMovieTextInputs = new Dictionary<TextBoxBase, string>()
            {
                {txtElokuvanNimi, "[syötä elokuvan nimi]"},
                {txtElokuvanJulkaisuvuosi, $"{DateTime.Today.Year}"},
                {txtElokuvanKesto, "0"},
                {txtBoxElokuvanArvio, "[Kirjoita arvio tähän]"}
            };
            TextInputs.SetDefaultTexts(defaultMovieTextInputs);
            TextInputs.ResetAllTextElementsToDefaultTexts();

        }

        private void Tietoja_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Klaus Kinnunen");
        }

        private void btnUusiTietue_Click(object sender, EventArgs e)
        {
            TextInputs.ResetAllTextElementsToDefaultTexts();
        }

        private void btnPoistu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtElokuvanNimi_MouseClick(object sender, MouseEventArgs e)
        {
            txtElokuvanNimi.Text = "";
        }

        private void txtElokuvanJulkaisuvuosi_MouseClick(object sender, MouseEventArgs e)
        {
            txtElokuvanJulkaisuvuosi.Text = "";
        }

        private void txtElokuvanKesto_MouseClick(object sender, MouseEventArgs e)
        {
            txtElokuvanKesto.Text = "";
        }

        private void txtElokuvanJulkaisuvuosi_Leave(object sender, EventArgs e)
        {
            TextInputs.ResetToDefaultTextIfEmpty(txtElokuvanJulkaisuvuosi);
        }



        private void txtElokuvanNimi_Leave(object sender, EventArgs e)
        {
            TextInputs.ResetToDefaultTextIfEmpty(txtElokuvanNimi);
        }

        private void txtElokuvanKesto_Leave(object sender, EventArgs e)
        {
            TextInputs.ResetToDefaultTextIfEmpty(txtElokuvanKesto);
        }

        private void txtBoxElokuvanArvio_Leave(object sender, EventArgs e)
        {
            TextInputs.ResetToDefaultTextIfEmpty(txtBoxElokuvanArvio);
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            if (TextInputs.MovieParamsAreValid())
            {
                MessageBox.Show("kaikki ok");
            }
        }
    }
}