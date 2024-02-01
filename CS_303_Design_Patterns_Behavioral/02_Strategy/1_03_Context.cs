namespace _02_Strategy
{
    // Context class that uses the strategy
    public class Character
    {
        private IAttackStrategy attackStrategy;

        public Character(IAttackStrategy strategy)
        {
            this.attackStrategy = strategy;
        }

        public void SetAttackStrategy(IAttackStrategy strategy)
        {
            this.attackStrategy = strategy;
        }

        public void Attack()
        {
            attackStrategy.Attack();
        }
    }

}
