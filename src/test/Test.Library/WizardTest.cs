using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    /// <summary>
    /// Clase WizardTest, dentro de esta se van a verificar los metodos que el personaje Wizard tiene.
    /// </summary>
    public class WizardTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack cuando atacan al Wizard
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {
            Knight knight1 = new Knight("knight1");
            knight1.Sword = new Sword();
            knight1.Armor = new Armor();
            knight1.Shield = new Shield();

            Wizard gandalf = new Wizard("Gandalf");
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[] { new Spell() };
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            gandalf.ReceiveAttack(knight1.AttackValue);
            Assert.AreEqual(100, gandalf.Health); //No logra realizarle daño debido a la alta defensa del Wizard
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al Wizard
        /// </summary>
        [Test]
        public void CureTest()
        {
            Knight knight1 = new Knight("knight1");
            knight1.Sword = new Sword();
            knight1.Armor = new Armor();
            knight1.Shield = new Shield();

            Wizard gandalf = new Wizard("Gandalf");
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[] { new Spell() };
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            gandalf.ReceiveAttack(knight1.AttackValue);
            gandalf.Cure();
            Assert.AreEqual(100, gandalf.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items del Wizard.
        /// </summary>
        [Test]
        public void ValueItemTest()
        {
            Wizard gandalf = new Wizard("Gandalf");
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[] { new Spell() };
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Assert.AreEqual(170, gandalf.AttackValue);
            Assert.AreEqual(170, gandalf.DefenseValue);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo AttackEnemy al momento en que el Wizard ataca a otro personaje.
        /// </summary>
        [Test]
        public void AttackEnemyTest()
        {
            Dwarf dwarf = new Dwarf("Enano");
            dwarf.Axe = new Axe();
            dwarf.Helmet = new Helmet();
            dwarf.Shield = new Shield();

            Wizard gandalf = new Wizard("Gandalf");
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[] { new Spell() };
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            gandalf.AttackEnemy(dwarf);
            Assert.AreEqual(0, dwarf.Health);
        }
    }
}