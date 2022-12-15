using DTO;

namespace Logic.Interfaces
{
    public interface IClubLogic
    {
        void AddClub(string name, string desc);
        IEnumerable<ClubDTO> getAll();
        ClubDTO getById(int clubid);
    }
}