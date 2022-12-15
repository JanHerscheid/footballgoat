using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Handlers
{
    public class ClubHandler : IClubHandler
    {
        public IEnumerable<ClubDTO> getAll()
        {
            using (var context = new ApplicationDataContext())
            {
                return context.Clubs.ToList();
            }
        }

        public ClubDTO getById(int clubid)
        {
            using (var context = new ApplicationDataContext())
            {
                return context.Clubs.First(x => x.Id == clubid);
            }
        }

        public void AddClub(string name, string desc)
        {
            using (var context = new ApplicationDataContext())
            {
                context.Database.EnsureCreated();
                context.Clubs.Add(new ClubDTO
                {
                    Name = name,
                    Description = desc
                });
                context.SaveChanges();
                context.Dispose();
            }
        }
    }
}
