using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public enum Position
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Attacker
    }
    public class PlayerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClubId { get; set; }
        public Position Position { get; set; }

        public PlayerDTO(int id, string name, int clubId, Position position)
        {
            Id = id;
            Name = name;
            ClubId = clubId;
            Position = position;
        }
    }
}
