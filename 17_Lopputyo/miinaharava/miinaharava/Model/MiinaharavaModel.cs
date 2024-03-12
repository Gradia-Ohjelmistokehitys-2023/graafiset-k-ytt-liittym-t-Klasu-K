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

        private int scale;
        private Random _random = new Random();

        public void GenerateMap(MapData map)
        {
            Map = map;
            int formTopbarHeight = 56;
            int formBasicWidth = 22;

            int HorizontalTileAmount = map.Width;
            int VerticalTileAmount = map.Height;
            scale = Presenter.View.Size.Width / HorizontalTileAmount;

            Presenter.View.Size = new Size(HorizontalTileAmount * scale + formBasicWidth, VerticalTileAmount * scale + formTopbarHeight);

            Map.tileGrid = new Tile[HorizontalTileAmount, VerticalTileAmount];
            for (int y = 0; y < VerticalTileAmount; y++) {
                for (int x = 0; x < HorizontalTileAmount; x++)
                {
                    Point location = new Point(x, y);
                    Map.tileGrid[x,y] = new Tile(location, scale, _random.Next(100) < 10, this);
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
    }
}
