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
            players.Add(new PlayerDTO("Antony", 3, Position.Attacker));
            players.Add(new PlayerDTO("Virgil van Dijk", 4, Position.Defender));
            players.Add(new PlayerDTO("Kevin de Bruyne", 5, Position.Midfielder));
        }

        public IEnumerable<PlayerDTO> getAllPlayers()
        {
            return players;
        }

        public void AddPlayer(string name, int clubid, Position Position)
        {
            using (var context = new ApplicationDataContext())
            {
                context.Database.EnsureCreated();
                context.Players.Add(new PlayerDTO(name, clubid, Position));
                context.SaveChanges();
            }
        }
    }
}
