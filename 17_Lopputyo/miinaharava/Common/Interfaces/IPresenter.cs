using Common.Data;

namespace Common.Interfaces
{
    public interface IPresenter
    {
        public IMainMenu MainMenu { get; set; }
        public IGameboard Gameboard { get; set; }

        void GameLost();
        void GameWon();
        void GenerateButtonForTile(Position location, Tile tile);
        void Initialize();
        void RevealTileToPlayer(Tile tile);
        void SetBoardSize(int width, int height);
        void StartGame(MapSizes mapSize);
        void TileFlagged(Tile tile);
        void TileOpened(Tile tile);
    }
}