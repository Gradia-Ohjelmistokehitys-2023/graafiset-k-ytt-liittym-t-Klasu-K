using miinaharava.Model;

namespace miinaharava
{
    public interface IMainMenu
    {
        event Action<MapSizes> GameStarted;
    }
}