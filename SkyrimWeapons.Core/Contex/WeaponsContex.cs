using Microsoft.EntityFrameworkCore;
using SkyrimWeapons.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimWeapons.Core.Contex
{
    public class WeaponsContex : DbContext
    {
        public DbSet<Weapon> Weapons => Set<Weapon>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedWeapons();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Weapons;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
