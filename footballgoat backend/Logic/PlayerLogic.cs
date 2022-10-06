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
    public class PlayerLogic : IPlayerLogic
    {
        private readonly IPlayerHandler _playerHandler;

        public PlayerLogic(IPlayerHandler playerhandler)
        {
            _playerHandler = playerhandler;
        }

        public IEnumerable<PlayerDTO> getAllPlayers()
        {
            return _playerHandler.getAllPlayers();
        }
    }
}
