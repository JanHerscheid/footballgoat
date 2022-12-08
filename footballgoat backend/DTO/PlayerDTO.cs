using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClubId { get; set; }
        public Position Position { get; set; }

        public PlayerDTO(string name, int clubId, Position position)
        {
            Name = name;
            ClubId = clubId;
            Position = position;
        }
    }
}
