using SkyrimWeapons.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimWeapons.Core.Entities
{
    public class Weapon : INamedEntity<Guid>
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }
        public int Damage { get; set; }
        public float Weight { get; set; }
        public int Gold { get; set; }
        public string Upgrade { get; set; }
        public string Perk { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public double? Speed { get; set; }
    }
}
