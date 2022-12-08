using DTO;

namespace Logic.Interfaces
{
    public interface IPlayerLogic
    {
        IEnumerable<PlayerDTO> getAllPlayers();
        void AddPlayer(string name, int clubid, Position Position);
    }
}