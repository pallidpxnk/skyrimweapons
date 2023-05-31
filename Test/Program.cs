using SkyrimWeapons.Core.Contex;
using SkyrimWeapons.Core.Entities;
using WeaponsRepositories;

var repository = new Repository<Weapon, Guid>(new WeaponsContex());
repository.Create(new Weapon
{
    Name = "ASSASASASAS",
    Category = "asdasdasd",
    Perk = "asdasdasd",
    Type = "asdasdasd",
    Upgrade = "asdasdasd"
});

foreach (var weapon in repository.GetAll())
{
    Console.WriteLine(weapon.Name);
}