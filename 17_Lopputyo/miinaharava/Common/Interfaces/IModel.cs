using Common.Data;

namespace Common.Interfaces
{
    public interface IModel
    {
        public int SafeTilesLeft { get; set; }
        public MapData Map { get; set; }
        public IPresenter Presenter { get; set; }
        void FirstReveal(Tile tile);
        void GenerateMap(MapData map);
    }
}