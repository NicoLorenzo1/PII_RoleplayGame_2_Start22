namespace RoleplayGame
{
    /// <summary>
    /// Interfaz ICharacter la cual están las firmas de los metodos los cuales tienen en común los personajes.
    /// </summary>
    public interface ICharacter
    {
        
        public void Cure();

        public void AttackEnemy(ICharacter EnemyToAttack);

        public void ReceiveAttack(int power);
    }

}
