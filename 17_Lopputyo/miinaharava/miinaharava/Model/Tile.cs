using miinaharava.Presenter;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miinaharava.Model
{
    public class Tile
    {
        List<Tile> _adjacentTiles = new List<Tile>();
        MiinaharavaModel _model;
        int? _adjacentMinesCount;
        Point _location;
        
        public Button Button;
        public bool tileHasBeenOpened = false;
        public bool IsMine = false;
        

        public Tile(Point location, int size, bool isMine, MiinaharavaModel model)
        {
            _model = model;
            Button = new Button();
            _location = location;
            IsMine = isMine;

            Button.Location = new Point(_location.X * size, _location.Y * size);
            Button.Size = new Size(size, size);
            Button.FlatStyle = FlatStyle.Flat;
            Button.BackColor = Color.LightGreen;
            Button.Click += (sender, e) => _model.Presenter.View.TileClicked(this);

            _model.Presenter.View.Controls.Add(Button);
 
        }

        public void InitializeTile()
        {
            int mapWidth = _model.Map.Width;
            int mapHeight = _model.Map.Height;
            for(int y = -1; y < 2; y++)
            {
                for (int x = -1; x < 2; x++)
                {
                    int tileLocationX = _location.X + x;
                    int tileLocationY = _location.Y + y;
                    if(tileLocationX > -1 && tileLocationX < mapWidth) {
                        if(tileLocationY > -1 && tileLocationY < mapHeight)
                        {
                            if(!(x == 0 && y == 0))
                            _adjacentTiles.Add(_model.Map.tileGrid[tileLocationX, tileLocationY]);
                        }
                    }
                }
            }



        }

        public void RevealThisTile()
        {
            tileHasBeenOpened = true;
            RevealTileToPlayer();
            if(GetAdjacentMineCount() == 0) 
            {
                foreach (var adjacentTile in _adjacentTiles)
                {
                    if (!adjacentTile.tileHasBeenOpened)
                    {
                        adjacentTile.RevealThisTile();
                    }
                }
            }
            
        }

        public int GetAdjacentMineCount()
        {
            if (_adjacentMinesCount != null) {
                return (int)_adjacentMinesCount;
            }
            else
            {
                _adjacentMinesCount = _adjacentTiles.Count(tile => tile.IsMine);
                return (int)_adjacentMinesCount;
            }
        }
        private void RevealTileToPlayer()
        {
            _model.Presenter.RevealTileToPlayer(this);
        }


    }
}
