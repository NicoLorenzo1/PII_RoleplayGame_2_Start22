using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    /// <summary>
    /// Clase KnightTest, dentro de esta se van a verificar los metodos que el personaje Knight tiene.
    /// </summary>
    public class KnightTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack cuando atacan al Knight
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

            knight1.ReceiveAttack(gandalf.AttackValue);
            Assert.AreEqual(0, knight1.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al Knight
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

            knight1.ReceiveAttack(gandalf.AttackValue);
            knight1.Cure();
            Assert.AreEqual(100, knight1.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items del Knight.
        /// </summary>
        [Test]
        public void ValueItemTest()
        {
            Knight knight1 = new Knight("knight1");
            knight1.Sword = new Sword();
            knight1.Armor = new Armor();
            knight1.Shield = new Shield();

            Assert.AreEqual(50, knight1.AttackValue);
            Assert.AreEqual(39, knight1.DefenseValue);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo AttackEnemy al momento en que el Knight1 ataca a otro personaje.
        /// </summary>
        [Test]
        public void AttackEnemyTest()
        {
            Dwarf dwarf = new Dwarf("Enano");
            dwarf.Axe = new Axe();
            dwarf.Helmet = new Helmet();
            dwarf.Shield = new Shield();

            Knight knight1 = new Knight("knight1");
            knight1.Sword = new Sword();
            knight1.Armor = new Armor();
            knight1.Shield = new Shield();

            knight1.AttackEnemy(dwarf);
            Assert.AreEqual(82, dwarf.Health);
        }
    }
}