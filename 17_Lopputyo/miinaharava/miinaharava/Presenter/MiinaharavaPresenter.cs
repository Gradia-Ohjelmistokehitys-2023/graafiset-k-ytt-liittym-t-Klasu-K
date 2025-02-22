﻿using miinaharava.Model;
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
        Stopwatch timer = new Stopwatch();

        bool _firstReveal = true;
        public void StartGame()
        {
            View.SetMainMenuVisibility(false);
            Model.GenerateMap(MapData.Size[View.mapSize]);
            timer.Start();
        }

        public void TileOpened(Tile tile)
        {
            if(_firstReveal)
            {
                Model.FirstReveal(tile);
                _firstReveal = false;
            }
            else
            {
                tile.RevealThisTile();
            }
            
        }

        public void TileFlagged(Tile tile)
        {
            if(!tile.tileHasBeenOpened)
            {
                View.FlagTile(tile);
            }
        }

        public void RevealTileToPlayer(Tile tile)
        {
            View.RevealTileToPlayer(tile, tile.GetAdjacentMineCount(), tile.IsMine);
        }

        public void GameLost()
        {
            GameOver(false);
        }

        public void GameWon()
        {
            GameOver(true);
        }

        private void GameOver(bool win)
        {
            timer.Stop();
            TimeSpan stopwatchElapsed = timer.Elapsed;
            View.ShowStats((int)stopwatchElapsed.TotalMinutes, (int)stopwatchElapsed.TotalSeconds, win);
        }
    }
}
