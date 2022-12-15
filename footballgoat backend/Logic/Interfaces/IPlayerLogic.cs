using DTO;

namespace Logic.Interfaces
{
    public interface IPlayerLogic
    {
        IEnumerable<PlayerDTO> getAllPlayers();
        void AddPlayer(string name, int clubid, Position Position);
        IEnumerable<PlayerDTO> getPlayersByClub(int clubid);
        PlayerDTO getPlayerById(int id);
        void TransferPlayer(int clubId, int playerId);
    }
}