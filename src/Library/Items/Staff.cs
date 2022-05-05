namespace RoleplayGame
{
    public class Staff : IItem
    {
        public int AttackValue 
        {
            get
            {
                return 100;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 100;
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