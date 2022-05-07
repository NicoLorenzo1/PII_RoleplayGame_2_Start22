using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ItemTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArmorReturnDefenseTest()
        {
            IItem armor = new Armor();
            Assert.AreEqual(25, armor.ReturnDefense());
        }

        [Test]
        public void AxeReturnDefenseTest()
        {
            IItem axe = new Axe();
            Assert.AreEqual(0, axe.ReturnDefense());
        }

        [Test]
        public void BowReturnDefenseTest()
        {
            IItem bow = new Bow();
            Assert.AreEqual(0, bow.ReturnDefense());
        }

        [Test]
        public void HelmetReturnDefenseTest()
        {
            IItem helmet = new Helmet();
            Assert.AreEqual(18, helmet.ReturnDefense());
        }

        [Test]
        public void ShieldReturnDefenseTest()
        {
            IItem shield = new Shield();
            Assert.AreEqual(14, shield.ReturnDefense());
        }

        [Test]
        public void SpellReturnDefenseTest()
        {
            IItem spell = new Spell();
            Assert.AreEqual(70, spell.ReturnDefense());
        }

        [Test]
        public void SpellsBookReturnDefenseTest()
        {
            SpellsBook spellsBook = new SpellsBook();
            Spell spell = new Spell();
            spellsBook.Spells = new Spell[] { spell };
            Assert.AreEqual(spell.DefenseValue, spellsBook.ReturnDefense());
        }

        [Test]
        public void StaffReturnDefenseTest()
        {
            IItem staff = new Staff();
            Assert.AreEqual(100, staff.ReturnDefense());
        }

        [Test]
        public void SwordReturnDefenseTest()
        {
            IItem sword = new Sword();
            Assert.AreEqual(0, sword.ReturnDefense());
        }

        [Test]
        public void ArmorReturnAttackTest()
        {
            IItem armor = new Armor();
            Assert.AreEqual(0, armor.ReturnAttack());
        }

        [Test]
        public void SpellReturnAttackTest()
        {
            IItem spell = new Spell();
            Assert.AreEqual(70, spell.ReturnAttack());
        }

        [Test]
        public void AxeReturnAttackTest()
        {
            IItem axe = new Axe();
            Assert.AreEqual(50, axe.ReturnAttack());
        }

        [Test]
        public void BowReturnAttackTest()
        {
            IItem bow = new Bow();
            Assert.AreEqual(15, bow.ReturnAttack());
        }

        [Test]
        public void HelmetReturnAttackTest()
        {
            IItem helmet = new Helmet();
            Assert.AreEqual(0, helmet.ReturnAttack());
        }

        [Test]
        public void ShieldReturnAttackTest()
        {
            IItem shield = new Shield();
            Assert.AreEqual(0, shield.ReturnAttack());
        }

        [Test]
        public void SpellsBookReturnAttackTest()
        {
            SpellsBook spellsBook = new SpellsBook();
            Spell spell = new Spell();
            spellsBook.Spells = new Spell[] { spell };
            Assert.AreEqual(spell.AttackValue, spellsBook.ReturnAttack());
        }

        [Test]
        public void StaffReturnAttackTest()
        {
            IItem staff = new Staff();
            Assert.AreEqual(100, staff.ReturnAttack());
        }

        [Test]
        public void SwordReturnAttackTest()
        {
            IItem sword = new Sword();
            Assert.AreEqual(50, sword.ReturnAttack());
        }

    }
}