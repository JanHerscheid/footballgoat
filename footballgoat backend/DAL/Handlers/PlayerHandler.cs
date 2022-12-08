using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace DAL.Handlers
{
    public class PlayerHandler : IPlayerHandler
    {
        /*
        private readonly ApplicationDataContext _context;
        public PlayerHandler(ApplicationDataContext context)
        {
            _context = context;
        }

        List<PlayerDTO> players;
        public PlayerHandler()
        {
            players = new List<PlayerDTO>();
            players.Add(new PlayerDTO("Antony", 3, Position.Attacker));
            players.Add(new PlayerDTO("Virgil van Dijk", 4, Position.Defender));
            players.Add(new PlayerDTO("Kevin de Bruyne", 5, Position.Midfielder));
        }
        */
        public IEnumerable<PlayerDTO> getAllPlayers()
        {
            using (var context = new ApplicationDataContext())
            {
                return context.Players;
            }
        }

        public IEnumerable<PlayerDTO> getPlayersByClub(int clubid)
        {
            using (var context = new ApplicationDataContext())
            {
                return context.Players.Where(x => x.ClubId == clubid);
            }
        }

        public void AddPlayer(string name, int clubid, Position Position)
        {
            using (var context = new ApplicationDataContext())
            {
                context.Database.EnsureCreated();
                context.Players.Add(new PlayerDTO(name, clubid, Position));
                context.SaveChanges();
                context.Dispose();
            }
        }
    }
}
