using miinaharava.Model;
using miinaharava.Presenter;
using Common;
using System.Diagnostics;
using System.Windows.Forms.Integration;

namespace miinaharava
{
    public partial class MiinaharavaView : Form, IMainMenu
    {
        Color defaultButtonColor = Color.LightGreen;
        Color buttonHighlightColor = Color.LightGray;
        Color flagColor = Color.LightPink;
        private MapSizes _mapSize;
        public MiinaharavaPresenter Presenter;

        public event Action<MapSizes> GameStarted;
        public MiinaharavaView()
        {
            InitializeComponent();
            btnMapSizeClick(btnMapSizeSmall, EventArgs.Empty);

        }


        public void TileClicked(object sender, MouseEventArgs e, Tile tile)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!tile.IsFlagged)
                {
                    Presenter.TileOpened(tile);
                }
            }
            else
            {
                Presenter.TileFlagged(tile);
            }

        }

        private void btnMapSizeClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            HighlightButton(btn);
            switch (btn.Name)
            {
                case "btnMapSizeSmall":
                    _mapSize = MapSizes.Small;

                    break;
                case "btnMapSizeMedium":
                    _mapSize = MapSizes.Medium;
                    break;
                case "btnMapSizeLarge":
                    _mapSize = MapSizes.Large;
                    break;
            }
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            GameStarted(_mapSize);
        }

        public void FlagTile(Tile tile)
        {
            if (tile.IsFlagged)
            {
                tile.Button.BackColor = defaultButtonColor;
                tile.IsFlagged = false;
            }
            else
            {
                tile.Button.BackColor = flagColor;
                tile.IsFlagged = true;
            }
        }

        public void RevealTileToPlayer(Tile tile, int adjacentMinesCount, bool isMine)
        {
            if (isMine)
            {
                tile.Button.BackColor = Color.Black;
            }
            else
            {
                if (adjacentMinesCount == 0)
                {
                    tile.Button.BackColor = Color.LightGray;
                }
                else
                {
                    tile.Button.Text = adjacentMinesCount.ToString();
                }
            }
            tile.Button.Refresh();
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

        public void ShowStats(int minutes, int seconds, bool win)
        {
            labelMinutes.Text = minutes.ToString("D2");
            labelSeconds.Text = seconds.ToString("D2");
            panelStats.Visible = true;
            panelStats.Location = new Point(0, 0);
            if (win)
            {
                labelResultText.Text = "You won";
                labelResultText.ForeColor = Color.Green;
            }
            else
            {
                labelResultText.Text = "You lost";
                labelResultText.ForeColor = Color.Red;
            }
        }

    }
}