namespace RoleplayGame
{
    public class Armor : IItem
    {
        public int DefenseValue
        {
            get
            {
                return 25;
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