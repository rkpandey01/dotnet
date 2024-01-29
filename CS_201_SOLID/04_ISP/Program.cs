Console.WriteLine("Interface Segregation Principle (ISP)");


/*
 * A class should not be forced to implement interfaces it does not use.
 * Instead of having a large, general-purpose interface, break it into smaller, specific interfaces.
 * Example: Suppose you have an interface called Worker with methods like work() and takeBreak(). 
If some classes only need to implement work() and not takeBreak(), 
it's better to have separate interfaces, like Workable and Breakable.
 

// Not following ISP
public interface IWorker
{
    void Work();
    void TakeBreak();
}

public class Manager : IWorker
{
    public void Work()
    {
        // Manage tasks
    }

    public void TakeBreak()
    {
        // Take a break
    }
}
 */


// Following ISP
public interface IWorker
{
    void Work();
}

public interface IBreakable
{
    void TakeBreak();
}

public class Manager : IWorker, IBreakable
{
    public void Work()
    {
        // Manage tasks
    }

    public void TakeBreak()
    {
        // Take a break
    }
}
