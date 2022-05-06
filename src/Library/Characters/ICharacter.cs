namespace RoleplayGame
{
    public interface ICharacter
    {

        public void Cure();

        public void AttackEnemy(ICharacter EnemyToAttack);
        public void ReceiveAttack(int power);




    }

}
