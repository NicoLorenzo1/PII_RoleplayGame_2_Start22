namespace RoleplayGame
{
    public class Axe : IItem
    {
        public int AttackValue 
        {
            get
            {
                return 50;
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