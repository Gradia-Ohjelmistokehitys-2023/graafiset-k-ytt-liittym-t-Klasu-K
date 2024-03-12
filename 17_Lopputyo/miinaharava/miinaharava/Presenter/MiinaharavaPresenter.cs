using miinaharava.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miinaharava.Presenter
{
    public class MiinaharavaPresenter
    {
        public MiinaharavaView View;
        public MiinaharavaModel Model;

        public void StartGame()
        {
            Debug.WriteLine(MapData.Size[View.mapSize].Name);
            View.SetMainMenuVisibility(false);
            Model.GenerateMap(MapData.Size[View.mapSize]);
        }

        public void TileClicked(Tile tile)
        {
            tile.RevealThisTile();
        }

        public void RevealTileToPlayer(Tile tile)
        {
            View.RevealTileToPlayer(tile, tile.GetAdjacentMineCount(), tile.IsMine);
        }
    }
}
