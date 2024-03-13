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
        MiinaharavaModel _model;
        int? _adjacentMinesCount;
        
        public List<Tile> AdjacentTiles = new List<Tile>();
        public Point Location;
        public Button Button;
        public bool tileHasBeenOpened = false;
        public bool IsMine = false;
        public bool IsFlagged;
        

        public Tile(Point location, int size, bool isMine, MiinaharavaModel model)
        {
            _model = model;
            Button = new Button();
            Location = location;
            IsMine = isMine;

            Button.Location = new Point(Location.X * size, Location.Y * size);
            Button.Size = new Size(size, size);
            Button.FlatStyle = FlatStyle.Flat;
            Button.BackColor = Color.LightGreen;
            Button.MouseUp += (sender, e) => _model.Presenter.View.TileClicked(sender, e, this);

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
                    int tileLocationX = Location.X + x;
                    int tileLocationY = Location.Y + y;
                    if(tileLocationX > -1 && tileLocationX < mapWidth) {
                        if(tileLocationY > -1 && tileLocationY < mapHeight)
                        {
                            if(!(x == 0 && y == 0))
                            AdjacentTiles.Add(_model.Map.tileGrid[tileLocationX, tileLocationY]);
                        }
                    }
                }
            }



        }

        public void RevealThisTile()
        {
            tileHasBeenOpened = true;
            RevealTileToPlayer();
            if(IsMine)
            {
                _model.Presenter.GameLost();
                return;
            } else
            {
                _model.safeTilesLeft--;
                if(_model.safeTilesLeft == 0)
                {
                    _model.Presenter.GameWon();
                    return;
                }
            }
            if(GetAdjacentMineCount() == 0) 
            {
                foreach (var adjacentTile in AdjacentTiles)
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
                _adjacentMinesCount = AdjacentTiles.Count(tile => tile.IsMine);
                return (int)_adjacentMinesCount;
            }
        }
        private void RevealTileToPlayer()
        {
            _model.Presenter.RevealTileToPlayer(this);
        }


    }
}
