namespace RoleplayGame
{
    public class Shield : IItem
    {
        public int DefenseValue
        {
            get
            {
                return 14;
            }
        }
        public int attackValue
        {
            get
            {
                return 0;
            }
        }

        public int ReturnDefense()
        {
            return DefenseValue;
        }

        public int ReturnAttack()
        {
            return attackValue;
        }
    }
}