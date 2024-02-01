namespace _02_Strategy
{
    // Concrete strategy 1
    public class SwordAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Attacking with a sword!");
        }
    }

    // Concrete strategy 2
    public class BowAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Attacking with a bow and arrow!");
        }
    }

    // Concrete strategy 3
    public class FireballAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Casting fireball spell!");
        }
    }

}
