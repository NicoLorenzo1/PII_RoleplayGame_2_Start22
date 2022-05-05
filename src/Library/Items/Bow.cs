namespace RoleplayGame
{
    public class Bow : IItem
    {
        public int AttackValue 
        {
            get
            {
                return 15;
            } 
        }
        public int DefenseValue 
        {
            get
            {
                return 0;
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