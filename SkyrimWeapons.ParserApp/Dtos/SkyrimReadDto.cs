using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimWeapons.ParserApp.Dtos
{
    public class SkyrimReadDto
    {
        // Name,Damage,Weight,Gold,Upgrade,Perk,Type,Category,Speed

        public string Name { get; set; }
        public int Damage { get; set; }
        public float Weight { get; set; }
        public int Gold { get; set; }
        public string Upgrade { get; set; }
        public string Perk { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public double? Speed { get; set; }


        public override string ToString()
        {
            return $"{Name}, {Damage}, {Weight}, {Gold}, {Upgrade}, {Perk}, {Type}, {Category}, {Speed}";
        }
    }
}
