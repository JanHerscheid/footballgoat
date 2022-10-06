using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace DAL.Handlers
{
    public class PlayerHandler : IPlayerHandler
    {
        List<PlayerDTO> players;
        public PlayerHandler()
        {
            players = new List<PlayerDTO>();
            players.Add(new PlayerDTO(1, "Antony", 3, Position.Attacker));
            players.Add(new PlayerDTO(2, "Virgil van Dijk", 4, Position.Defender));
            players.Add(new PlayerDTO(3, "Kevin de Bruyne", 5, Position.Midfielder));
        }

        public IEnumerable<PlayerDTO> getAllPlayers()
        {
            return players;
        }
    }
}
