namespace RoleplayGame
{
    public class Spell : IItem
    {
        public int AttackValue
        {
            get
            {
                return 70;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 70;
            }
        }
        public int ReturnAttack()
        {
            return AttackValue;
        }

        public int ReturnDefense()
        {
            return DefenseValue;
        }
    }
}