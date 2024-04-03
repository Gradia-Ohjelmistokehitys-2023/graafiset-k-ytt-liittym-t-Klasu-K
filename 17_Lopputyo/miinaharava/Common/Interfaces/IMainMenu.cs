using Common.Data;

namespace Common.Interfaces
{
    public interface IMainMenu
    {
        event Action<MapSizes> GameStarted;
        public void OpenGameboard();
    }
}