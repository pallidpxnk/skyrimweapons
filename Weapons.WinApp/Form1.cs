using SkyrimWeapons.Core.Common;
using SkyrimWeapons.Core.Contex;
using SkyrimWeapons.Core.Entities;
using WeaponsRepositories;

namespace Weapons.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            button1.Click += button1_Click;
            //var repository = new Repository<Weapon, Guid>(new WeaponsContex());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var repository = new Repository<Weapon, Guid>(new WeaponsContex());
            foreach (var weapon in repository.GetAll().ToList())
            {
                listBox1.Items.Add($"{weapon.Name}, {weapon.Damage}, {weapon.Weight}, {weapon.Gold}, {weapon.Upgrade}, {weapon.Perk}, {weapon.Type}, {weapon.Category}, {weapon.Speed}");
            }
        }

        private void UpdateList1()
        {
            listBox1.Items.Clear();
            var repository = new Repository<Weapon, Guid>(new WeaponsContex());
            foreach (var weapon in repository.GetAll().ToList())
            {
                listBox1.Items.Add($"{weapon.Name}, {weapon.Damage}, {weapon.Weight}, {weapon.Gold}, {weapon.Upgrade}, {weapon.Perk}, {weapon.Type}, {weapon.Category}, {weapon.Speed}");
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repository = new Repository<Weapon, Guid>(new WeaponsContex());
            repository.Create(new Weapon
            {
                Name = textBox1.Text,
                Damage = int.Parse(textBox2.Text),
                Weight = int.Parse(textBox3.Text),
                Gold = int.Parse(textBox4.Text),
                Upgrade = textBox5.Text,
                Perk = textBox6.Text,
                Type = textBox7.Text,
                Category = textBox8.Text,
                Speed = double.Parse(textBox9.Text)
            });
            UpdateList1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var repository = new Repository<Weapon, Guid>(new WeaponsContex());
            while (listBox1.SelectedIndex != -1)
            {
                string selectedString = listBox1.SelectedItem.ToString();
                string[] words = selectedString.Split(',');

                var weapon = repository.GetAll().FirstOrDefault(w => w.Name == words[0]);
                if (weapon != null)
                {
                    var weaponToDelete = repository.Get(weapon.Id);
                    repository.Delete(weaponToDelete);
                }

                UpdateList1();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var repository = new Repository<Weapon, Guid>(new WeaponsContex());
            while (listBox1.SelectedIndex != -1)
            {
                string selectedString = listBox1.SelectedItem.ToString();
                string[] words = selectedString.Split(',');

                var weapon = repository.GetAll().FirstOrDefault(w => w.Name == words[0]);
                if (weapon != null)
                {
                    var weaponToDelete = repository.Get(weapon.Id);
                    weaponToDelete.Name = textBox1.Text;
                    weaponToDelete.Damage = int.Parse(textBox2.Text);
                    weaponToDelete.Weight = int.Parse(textBox3.Text);
                    weaponToDelete.Gold = int.Parse(textBox4.Text);
                    weaponToDelete.Upgrade = textBox5.Text;
                    weaponToDelete.Perk = textBox6.Text;
                    weaponToDelete.Type = textBox7.Text;
                    weaponToDelete.Category = textBox8.Text;
                    weaponToDelete.Speed = double.Parse(textBox9.Text);
                    repository.Update(weaponToDelete);
                }

                UpdateList1();
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            var repository = new Repository<Weapon, Guid>(new WeaponsContex());
            var weapon = repository.GetAll().FirstOrDefault(w => w.Name == textBox10.Text);
            if (weapon != null)
                listBox2.Items.Add($"{weapon.Name}, {weapon.Damage}, {weapon.Weight}, {weapon.Gold}, {weapon.Upgrade}, {weapon.Perk}, {weapon.Type}, {weapon.Category}, {weapon.Speed}");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}