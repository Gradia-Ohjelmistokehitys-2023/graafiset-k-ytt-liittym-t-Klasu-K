using miinaharava.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.VisualBasic.Logging;
using Common.Interfaces;
using Common.Data;

namespace miinaharava.Model;

public class MiinaharavaModel : IModel
{
    public IPresenter Presenter { get; set; }
    public MapData Map { get; set; }
    public int SafeTilesLeft { get; set; }

    private int scale;
    private Random _random = new Random();

    public void GenerateMap(MapData map)
    {
        Map = map;

        int formTopbarHeight = 56;
        int formBasicWidth = 22;

        int horizontalTileAmount = Map.Width;
        int verticalTileAmount = Map.Height;
        Presenter.SetBoardSize(horizontalTileAmount, verticalTileAmount);
        SafeTilesLeft = Map.Width * Map.Height - Map.MineAmount; ;
        int unplacedMinesLeft = Map.MineAmount;
        int unplacedSafeTilesLeft = SafeTilesLeft;
        scale = Presenter.Gameboard.Width / horizontalTileAmount;

        Presenter.Gameboard.SetSize(horizontalTileAmount * scale + formBasicWidth, verticalTileAmount * scale + formTopbarHeight);

        Map.tileGrid = new Tile[horizontalTileAmount, verticalTileAmount];
        for (int y = 0; y < verticalTileAmount; y++)
        {
            for (int x = 0; x < horizontalTileAmount; x++)
            {
                bool isMine = _random.Next(unplacedMinesLeft + unplacedSafeTilesLeft) < unplacedMinesLeft;

                if (isMine) { unplacedMinesLeft--; }
                else { unplacedSafeTilesLeft--; }

                Position location = new Position(x, y);
                Tile tile = new Tile(location, isMine, this);
                Map.tileGrid[x, y] = tile;
                Presenter.GenerateButtonForTile(location, tile);
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
        List<Tile> middleAndAdjacentTiles = new List<Tile>(MiddleTile.AdjacentTiles) { MiddleTile };
        Position MiddleTileLoc = MiddleTile.Location;
        foreach (var tile in middleAndAdjacentTiles)
        {

            if (tile.IsMine)
            {
                tile.IsMine = false;
                bool safeTileFound = false;
                while (!safeTileFound)
                {
                    int xLoc = _random.Next(Map.Width);
                    int yLoc = _random.Next(Map.Height);
                    Tile tileOnLocation = Map.tileGrid[xLoc, yLoc];
                    if (!tileOnLocation.IsMine)
                    {
                        if (!(xLoc <= MiddleTile.Location.X + 1 && MiddleTile.Location.X - 1 <= xLoc) || !(yLoc <= MiddleTile.Location.Y + 1 && MiddleTile.Location.Y - 1 <= yLoc))
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
