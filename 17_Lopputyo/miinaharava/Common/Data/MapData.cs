using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data
{
    public class MapData
    {
        public Tile[,] tileGrid;
        public int MineAmount { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public string Name { get; private set; }

        public static Dictionary<MapSizes, MapData> Size = new Dictionary<MapSizes, MapData>
        {
            {MapSizes.Small, new MapData(10, 9, 9, "small")},
            {MapSizes.Medium, new MapData(40, 16, 16, "medium")},
            {MapSizes.Large, new MapData(99, 30, 16, "large")}
        };

        MapData(int mineAmount, int width, int height, string name)
        {
            MineAmount = mineAmount;
            Width = width;
            Height = height;
            Name = name;
        }
    }
}
