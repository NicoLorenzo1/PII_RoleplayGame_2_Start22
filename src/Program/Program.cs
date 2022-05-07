using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[] { new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();

            Knight knight1 = new Knight("knight1");
            knight1.Sword = new Sword();
            knight1.Armor = new Armor();
            knight1.Shield = new Shield();

            //knight1 ataca a gimili
            knight1.AttackEnemy(gimli);
            Console.WriteLine($"Knight1 attacks Gimli with ⚔️ {knight1.AttackValue}");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            gimli.Cure();
            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            //gandalf ataca a gimili
            gandalf.AttackEnemy(gimli);
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");
            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            //gimili ataca a gandalf
            gimli.AttackEnemy(gandalf);
            Console.WriteLine($"Gimili attacks Gandalf with ⚔️ {gimli.AttackValue}");
            Console.WriteLine(gandalf.DefenseValue); //Debido a que la defensa es muy alta no le hace nada el daño de gimili ya que es de 25
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");



        }
    }
}
