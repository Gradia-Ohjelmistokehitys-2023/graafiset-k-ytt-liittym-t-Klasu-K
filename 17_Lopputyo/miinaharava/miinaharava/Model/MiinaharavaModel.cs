using miinaharava.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.VisualBasic.Logging;

namespace miinaharava.Model
{
    public class MiinaharavaModel
    {
        public MiinaharavaPresenter Presenter;
        public MapData Map;

        public int safeTilesLeft;

        private int scale;
        private Random _random = new Random();

        public void GenerateMap(MapData map)
        {
            Map = map;

            int formTopbarHeight = 56;
            int formBasicWidth = 22;

            int horizontalTileAmount = Map.Width;
            int verticalTileAmount = Map.Height;
            safeTilesLeft = Map.Width * Map.Height - Map.MineAmount; ;
            int unplacedMinesLeft = Map.MineAmount;
            int unplacedSafeTilesLeft = safeTilesLeft;
            scale = Presenter.View.Size.Width / horizontalTileAmount;

            Presenter.View.Size = new Size(horizontalTileAmount * scale + formBasicWidth, verticalTileAmount * scale + formTopbarHeight);

            Map.tileGrid = new Tile[horizontalTileAmount, verticalTileAmount];
            for (int y = 0; y < verticalTileAmount; y++) {
                for (int x = 0; x < horizontalTileAmount; x++)
                {
                    bool isMine = _random.Next(unplacedMinesLeft + unplacedSafeTilesLeft) < unplacedMinesLeft;

                    if(isMine) { unplacedMinesLeft--; }
                    else { unplacedSafeTilesLeft--; }
                    
                    Point location = new Point(x, y);
                    Map.tileGrid[x,y] = new Tile(location, scale, isMine, this);
                }
            }
            InitializeAllTiles();
        }

        private void InitializeAllTiles()
        {
            foreach (Tile tile in Map.tileGrid)
            {
                tile.InitializeTile();
            }
        }

        public void FirstReveal(Tile tile)
        {
            RemoveAdjacentMinesAndSelf(tile);
            tile.RevealThisTile();
        }

        private void RemoveAdjacentMinesAndSelf(Tile MiddleTile)
        {
            List<Tile> middleAndAdjacentTiles = new List<Tile>(MiddleTile.AdjacentTiles) { MiddleTile};
            Point MiddleTileLoc = MiddleTile.Location;
            foreach (var tile in middleAndAdjacentTiles)
            {
                
                if (tile.IsMine)
                {
                    tile.IsMine = false;
                    bool safeTileFound = false;
                    while(!safeTileFound)
                    {
                        int xLoc = _random.Next(Map.Width);
                        int yLoc = _random.Next(Map.Height);
                        Tile tileOnLocation = Map.tileGrid[xLoc, yLoc];
                        if (!tileOnLocation.IsMine)
                        {   
                            if(!(xLoc <= MiddleTile.Location.X+1 && MiddleTile.Location.X - 1 <= xLoc) || !(yLoc <= MiddleTile.Location.Y + 1 && MiddleTile.Location.Y - 1 <= yLoc))
                            {
                                safeTileFound = true;
                                tileOnLocation.IsMine = true;
                            }                          
                        }
                    }
                }
            }
        }

    }
}
