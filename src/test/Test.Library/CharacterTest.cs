using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    /// <summary>
    /// Clase CharacterTest, dentro de esta se van a verificar los metodos que los personajes tienen.
    /// </summary>
    public class CharacterTest
    {
        /// <summary>
        /// Test que se encarga de verificar el metodo receiveAttack al momento de atacar a un personaje, en este caso al Knight
        /// </summary>
        [Test]
        public void ReceiveAttackTest()
        {
            Dwarf dwarf = new Dwarf("Enano");
            dwarf.Helmet = new Helmet();
            dwarf.Axe = new Axe();

            Knight knight1 = new Knight("knight1");
            knight1.Sword = new Sword();
            knight1.Armor = new Armor();
            knight1.Shield = new Shield();

            knight1.ReceiveAttack(dwarf.AttackValue);
            Assert.AreEqual(89, knight1.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar el metodo Cure al momento de curar un personaje, en este caso al Knight
        /// </summary>
        [Test]
        public void CureTest()
        {
            Dwarf dwarf = new Dwarf("Enano");
            dwarf.Axe = new Axe();

            Knight knight1 = new Knight("knight1");
            knight1.Sword = new Sword();
            knight1.Armor = new Armor();
            knight1.Shield = new Shield();

            dwarf.AttackEnemy(knight1);
            knight1.Cure();
            Assert.AreEqual(100, knight1.Health);
        }

        /// <summary>
        /// Test que se encarga de verificar si se asignan a los personajes los valores correspondientes de ataque y defensa al crear los items.
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
        /// Test que se encarga de verificar el metodo AttackEnemy, en este caso se ataca al Dwarf y se verifica que el daño realizado sea 
        /// el ataque del Knight(50) menos la defensa del Dwarf(14 + 18).
        /// Tambien se verifica que el ataque del Knight sea igual a la defensa del Dwarf + 18 que es el efecto que resta del ataque(ya que la espada tiene 50 de ataque)
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
            Assert.AreEqual(knight1.AttackValue, dwarf.DefenseValue + 18);
        }
    }
}