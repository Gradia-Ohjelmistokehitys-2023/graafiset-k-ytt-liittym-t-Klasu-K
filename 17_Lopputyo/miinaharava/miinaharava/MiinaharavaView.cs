using miinaharava.Model;
using miinaharava.Presenter;
using System.Diagnostics;

namespace miinaharava
{
    public partial class MiinaharavaView : Form
    {
        Color defaultButtoncolor = Color.White;
        Color buttonHighlightColor = Color.LightGray;
        public MapSizes mapSize { get; private set; }
        public MiinaharavaPresenter Presenter;

        public event Action GameStarted;
        public MiinaharavaView()
        {
            InitializeComponent();
            btnMapSizeClick(btnMapSizeSmall, EventArgs.Empty);

        }

        private void btnMapSizeClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            HighlightButton(btn);
            switch (btn.Name)
            {
                case "btnMapSizeSmall":
                    mapSize = MapSizes.Small;

                    break;
                case "btnMapSizeMedium":
                    mapSize = MapSizes.Medium;
                    break;
                case "btnMapSizeLarge":
                    mapSize = MapSizes.Large;
                    break;
            }
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            GameStarted();
        }

        public void SetMainMenuVisibility(bool visible)
        {
            gbMainMenu.Visible = visible;
            panelMapSizeBtns.Visible = visible;
        }

        void HighlightButton(Button buttonToHighlight)
        {
            foreach (Button btn in panelMapSizeBtns.Controls.OfType<Button>())
            {
                btn.BackColor = DefaultBackColor;
            }
            buttonToHighlight.BackColor = buttonHighlightColor;
        }

        private void MiinaharavaView_Load(object sender, EventArgs e)
        {
            GameStarted += Presenter.StartGame;
        }
    }
}