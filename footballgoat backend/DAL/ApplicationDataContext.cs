using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ApplicationDataContext : DbContext
    {
        /*
        //ik heb deze constructor nodig voor de in memory database van mijn tests
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options)
            : base(options) 
        { 
            
        }
        //deze constructor staat hier zodat ik in mijn methodes niets mee hoef te geven aan de constructor
        public ApplicationDataContext()
        {

        }
        */

        public DbSet<PlayerDTO> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=studmysql01.fhict.local;Uid=dbi406978;Database=dbi406978;Pwd=Sudblamzud2;",
            new MySqlServerVersion(new Version(5, 7, 26)));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PlayerDTO>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
            });
        }
    }
}
