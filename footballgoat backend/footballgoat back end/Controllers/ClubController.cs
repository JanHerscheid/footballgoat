using DTO;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace footballgoat_back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController
    {
        IClubLogic _clubLogic;
        public ClubController(IClubLogic clubLogic)
        {
            _clubLogic = clubLogic;
        }

        [HttpPost]
        [Route("Add")]
        public void AddClub(string name, string desc)
        {
            _clubLogic.AddClub(name, desc);
        }
        [HttpGet]
        public IEnumerable<ClubDTO> getAll() {
            return _clubLogic.getAll();
        }

        [HttpGet]
        [Route("Id")]
        public ClubDTO getById(int clubid) { 
            return _clubLogic.getById(clubid);
        }
    }
}
