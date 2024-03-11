using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miinaharava.Model
{
	public class Map
	{
		public int MineAmount { get; private set; }
		public int Width { get; private set; }
		public int Height { get; private set; }
		public string Name { get; private set; }

        public static Dictionary<MapSizes, Map> Size = new Dictionary<MapSizes, Map>
		{
			{MapSizes.Small, new Map(10, 9, 9, "small")},
			{MapSizes.Medium, new Map(40, 16, 16, "medium")},
            {MapSizes.Large, new Map(99, 30, 16, "large")}
        };

		Map(int mineAmount, int width, int height, string name)
		{
			MineAmount = mineAmount;
			Width = width;
			Height = height;
			Name = name;
		}
	}
}
