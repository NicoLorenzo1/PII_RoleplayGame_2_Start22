namespace RoleplayGame
{
    public class Sword : IItem
    {
        public int AttackValue 
        {
            get
            {
                return 20;
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