﻿using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           // SpellsBook book = new SpellsBook();
            //book.Spells = new Spell[]{ new Spell() };

            //Wizard gandalf = new Wizard("Gandalf");
            //gandalf.Staff = new Staff();
            //gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();

            Knight knight1 = new Knight("knight1");
            knight1.Sword = new Sword();
            knight1.Armor = new Armor();
            knight1.Shield = new Shield();

            knight1.AttackEnemy(gimli);
            Console.WriteLine(knight1.AttackValue);
            Console.WriteLine(gimli.DefenseValue);


            //Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            //Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            //gimli.Attack(gandalf.AttackValue);

            //Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            //gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
