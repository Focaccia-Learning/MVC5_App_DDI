using MVC5_App_DDI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5_App_DDI.Database
{
    public class OnlineGameContext : DbContext
    {
        public DbSet<Gamer> Gamers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ////1.
            //modelBuilder.Entity<Gamer>()
            //    .Map(m => m.Requires("IsActivated")
            //    .HasValue(true))
            //    .Ignore(m => m.IsActivated);

            //2.
            modelBuilder.Entity<Gamer>()
                .Map(m => m.Requires("IsActivated")
                .HasValue(true))
                .Ignore(m => m.IsActivated)
                .HasKey(pk => pk.Id)
                .ToTable("Gamer");
            base.OnModelCreating(modelBuilder);
        }
    }
}
