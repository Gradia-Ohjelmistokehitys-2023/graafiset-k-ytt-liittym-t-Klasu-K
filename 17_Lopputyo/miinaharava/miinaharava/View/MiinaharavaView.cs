using miinaharava.Presenter;
using System.Diagnostics;
using System.Windows.Forms.Integration;
using Common.Interfaces;
using Common.Data;

namespace miinaharava
{
    public partial class MiinaharavaView : Form, IMainMenu, IGameboard
    {
        Color defaultButtonColor = Color.LightGreen;
        Color buttonHighlightColor = Color.LightGray;
        Color flagColor = Color.LightPink;
        private MapSizes _mapSize;
        private Button[,] buttons;
        public MiinaharavaPresenter Presenter;

        public event Action<MapSizes> GameStarted;
        public MiinaharavaView()
        {
            InitializeComponent();
            btnMapSizeClick(btnMapSizeSmall, EventArgs.Empty);

        }


        public void TileClicked(object sender, MouseEventArgs e, Tile  tile)
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

        public void OpenGameboard()
        {
            SetMainMenuVisibility(false);
        }

        public void SetBoardSize(int width, int height)
        {
            buttons = new Button[width, height];
        }

        public void GenerateButtonForTile(Position location, Tile tile)
        {
            int size = 40;
            Button button = new Button();
            button.Location = new Point(location.X * size, location.Y * size);
            button.Size = new Size(size, size);
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.LightGreen;
            button.MouseUp += (sender, e) => TileClicked(sender, e, tile);

            Controls.Add(button);
            buttons[location.X, location.Y] = button;
        }

        public void FlagTile(Tile tile)
        {
            Button button = buttons[tile.Location.X, tile.Location.Y];
            if (tile.IsFlagged)
            {
                button.BackColor = defaultButtonColor;
                tile.IsFlagged = false;
            }
            else
            {
                button.BackColor = flagColor;
                tile.IsFlagged = true;
            }
        }

        public void SetSize(int width, int height)
        {
            Size = new Size(width, height);
        }

        public void RevealTileToPlayer(Tile tile, int adjacentMinesCount, bool isMine)
        {
            Button button = buttons[tile.Location.X, tile.Location.Y];
            if (isMine)
            {
                button.BackColor = Color.Black;
            }
            else
            {
                if (adjacentMinesCount == 0)
                {
                    button.BackColor = Color.LightGray;
                }
                else
                {
                    button.Text = adjacentMinesCount.ToString();
                }
            }
            button.Refresh();
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

        private Button ButtonOnPosition(Point location)
        {
            return buttons[location.X, location.Y];
        }
    }
}