namespace RoleplayGame
{
    public class Helmet : IItem
    {
        public int DefenseValue
        {
            get
            {
                return 18;
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