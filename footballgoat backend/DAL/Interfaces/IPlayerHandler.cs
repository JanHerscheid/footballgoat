using DTO;

namespace DAL.Interfaces
{
    public interface IPlayerHandler
    {
        IEnumerable<PlayerDTO> getAllPlayers();
    }
}