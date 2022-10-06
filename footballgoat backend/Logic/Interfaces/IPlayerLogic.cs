using DTO;

namespace Logic.Interfaces
{
    public interface IPlayerLogic
    {
        IEnumerable<PlayerDTO> getAllPlayers();
    }
}