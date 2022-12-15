using DAL.Interfaces;
using DTO;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ClubLogic : IClubLogic
    {
        private readonly IClubHandler _clubHandler;

        public ClubLogic(IClubHandler clubhandler)
        {
            _clubHandler = clubhandler;
        }

        public void AddClub(string name, string desc)
        {
            _clubHandler.AddClub(name, desc);
        }
        public IEnumerable<ClubDTO> getAll()
        {
            return _clubHandler.getAll();
        }
        public ClubDTO getById(int clubid)
        {
            return _clubHandler.getById(clubid);
        }
    }
}
