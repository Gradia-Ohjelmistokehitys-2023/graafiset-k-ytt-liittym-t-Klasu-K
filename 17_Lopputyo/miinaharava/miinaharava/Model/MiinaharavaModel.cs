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

        public void GenerateMap(Map map)
        {
            int formTopbarHeight = 56;
            int formBasicWidth = 22;

            int HorizontalTileAmount = map.Width;
            int VerticalTileAmount = map.Height;
            int scale = Presenter.View.Size.Width / HorizontalTileAmount;

            Presenter.View.Size = new Size(HorizontalTileAmount * scale + formBasicWidth, VerticalTileAmount * scale + formTopbarHeight);


            for (int y = 0; y < VerticalTileAmount; y++) {
                for (int x = 0; x < HorizontalTileAmount; x++)
                {
                    Button tile = new Button();
                    tile.Location = new Point(x * scale, y * scale);    
                    tile.Size = new Size(scale, scale);
                    tile.FlatStyle = FlatStyle.Flat;
                    tile.BackColor = Color.LightGreen;
                    Presenter.View.Controls.Add(tile);
                }
            }
        }
    }
}
