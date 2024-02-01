// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dependency Inversion Principle (DIP)");


/*
 * High-level modules should not depend on low-level modules; both should depend on abstractions.
 * Abstractions should not depend on details; details should depend on abstractions.
 * Example: Instead of a high-level module directly depending on a low-level module,
both should depend on an abstraction. 
For instance, if you have a class OrderProcessor that needs to interact with a database, 
create an interface like Database and have both OrderProcessor 
and the actual database implementation depend on this abstraction.
 


// Not following DIP
public class LightBulb
{
    public void TurnOn()
    {
        // Turn on the light bulb
    }
}

public class Switch
{
    private readonly LightBulb bulb;

    public Switch()
    {
        this.bulb = new LightBulb();
    }

    public void Operate()
    {
        // Operate the light switch
        bulb.TurnOn();
    }
}

 
 */



// Following DIP
public interface ISwitchable
{
    void TurnOn();
}

public class LightBulb : ISwitchable
{
    public void TurnOn()
    {
        // Turn on the light bulb
    }
}

public class Switch
{
    private readonly ISwitchable device;

    public Switch(ISwitchable device)
    {
        this.device = device;
    }

    public void Operate()
    {
        // Operate the switch
        device.TurnOn();
    }
}