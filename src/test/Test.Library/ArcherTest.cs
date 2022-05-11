using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    /// <summary>
    /// Clase ArcherTestTest, dentro de esta se van a verificar los metodos que el personaje Archer tiene.
    /// </summary>
    public class ArcherTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack cuando atacan al Archer
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {
            Dwarf dwarf = new Dwarf("Enano");
            dwarf.Helmet = new Helmet();
            dwarf.Axe = new Axe();

            Archer archer = new Archer("Archer");
            archer.Helmet = new Helmet();
            archer.Bow = new Bow();

            archer.ReceiveAttack(dwarf.AttackValue);
            Assert.AreEqual(68, archer.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al Archer
        /// </summary>
        [Test]
        public void CureTest()
        {
            Dwarf dwarf = new Dwarf("Enano");
            dwarf.Axe = new Axe();

            Archer archer = new Archer("Archer");
            archer.Helmet = new Helmet();
            archer.Bow = new Bow();

            dwarf.AttackEnemy(archer);
            archer.Cure();
            Assert.AreEqual(100, archer.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items del archer.
        /// </summary>
        [Test]
        public void ValueItemTest()
        {
            Archer archer = new Archer("Archer");
            archer.Helmet = new Helmet();
            archer.Bow = new Bow();
            Assert.AreEqual(15, archer.AttackValue);
            Assert.AreEqual(18, archer.DefenseValue);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo AttackEnemy, en este caso el Archer ataca al Dwarf, no logra realizarle daño debido al bajo poder de ataque
        /// que tiene el archer y la lata defensa que tiene el Dwarf.
        /// </summary>
        [Test]
        public void AttackEnemyTest()
        {
            Dwarf dwarf = new Dwarf("Enano");
            dwarf.Axe = new Axe();
            dwarf.Helmet = new Helmet();
            dwarf.Shield = new Shield();

            Archer archer = new Archer("Archer");
            archer.Helmet = new Helmet();
            archer.Bow = new Bow();

            archer.AttackEnemy(dwarf);
            Assert.AreEqual(100, dwarf.Health);
        }
    }
}