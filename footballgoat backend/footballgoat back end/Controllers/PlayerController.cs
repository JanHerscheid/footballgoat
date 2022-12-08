using DTO;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace footballgoat_back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        IPlayerLogic _playerLogic;
        public PlayerController(IPlayerLogic playerLogic)
        {
            _playerLogic = playerLogic;
        }
    
        [HttpGet]
        public IEnumerable<PlayerDTO> getAllPlayers()
        {
            return _playerLogic.getAllPlayers();
        }

        [HttpPost]
        [Route("Add")]
        public void AddPlayer(string name, int clubid, Position Position) { 
            _playerLogic.AddPlayer(name, clubid, Position);
        }

        [HttpGet]
        [Route("GetClubSquad")]
        public IEnumerable<PlayerDTO> getPlayersByClub(int clubid) {
            return _playerLogic.getPlayersByClub(clubid);
        }
    }
}
