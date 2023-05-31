using Microsoft.EntityFrameworkCore;
using SkyrimWeapons.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SkyrimWeapons.Core.Contex
{
    public static class WeaponsContextSeedExtension
    {
        public static void SeedWeapons(this ModelBuilder builder)
        {
            builder.Entity<Weapon>().HasData(
                new Weapon { Name = "Weapon1", Damage = 23, Weight = 15, Gold = 1000, Upgrade = "None", Perk = "None", Type = "None", Category = "One Hand", Speed = 0 }
                );
        }
    }
}
