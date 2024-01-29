Console.WriteLine("Liskov Substitution Principle (LSP)");

/*
 * 
 * Subtypes should be substitutable for their base types without altering the correctness of the program.
 * If a class is a subtype of another class, it should be able to replace that class without affecting the behavior of the program.
 * Example: If you have a class hierarchy with a base class Bird and a derived class Penguin, 
   you should be able to use a Penguin wherever a Bird is expected without causing issues.
 

// Not following LSP

public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying");
    }
}

public class Penguin : Bird
{
    // Penguins can't fly, violating LSP
    public override void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}

 */


// Following LSP
public interface IFlyable
{
    void Fly();
}

public class Bird : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Flying");
    }
}

public class Penguin : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}
