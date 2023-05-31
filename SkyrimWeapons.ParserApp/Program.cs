using CsvHelper;
using SkyrimWeapons.Core.Contex;
using SkyrimWeapons.Core.Entities;
using SkyrimWeapons.ParserApp.Dtos;
using static System.Net.Mime.MediaTypeNames;


using (var ctx = new WeaponsContex())
{
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();

    Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} -- APP STARTED -- ");

    using (var reader = new StreamReader("Skyrim_Weapons.csv"))
    using (var csvReader = new CsvReader(reader, culture: System.Globalization.CultureInfo.CurrentCulture))
    {
        var records = csvReader.GetRecords<SkyrimReadDto>();

        var weapons = new List<Weapon>();

        int row = 0;

        foreach (var x in records)
        { 
            var weapon = new Weapon
            {
                Name = x.Name,
                Damage = x.Damage,
                Weight = x.Weight,
                Gold = x.Gold,
                Upgrade = x.Upgrade,
                Perk = x.Perk,
                Type = x.Type,
                Category = x.Category,
                Speed = x.Speed
            };
            Console.WriteLine($"{++row} : {weapon.Name}");
            weapons.Add(weapon);
        }
        ctx.Weapons.AddRange(weapons);
        ctx.SaveChanges();
        Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} -- WEAPONS ADDED -- ");
    }
}
