using DTO;

namespace DAL.Interfaces
{
    public interface IPlayerHandler
    {
        IEnumerable<PlayerDTO> getAllPlayers();
        void AddPlayer(string name, int clubid, Position Position);
        IEnumerable<PlayerDTO> getPlayersByClub(int clubid);
        PlayerDTO GetById(int playerId);
        void TransferPlayer(int clubId, int playerId);
    }
}