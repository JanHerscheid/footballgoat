using DTO;

namespace DAL.Interfaces
{
    public interface IClubHandler
    {
        void AddClub(string name, string desc);
        IEnumerable<ClubDTO> getAll();
        ClubDTO getById(int clubid);
    }
}