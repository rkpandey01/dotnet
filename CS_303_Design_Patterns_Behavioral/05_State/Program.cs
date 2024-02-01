using _05_State;

Console.WriteLine("05_State:");

AudioPlayer player = new AudioPlayer();

// Play from the Stopped state
player.Play();

// Pause from the Playing state
player.Pause();

// Stop from the Paused state
player.Stop();

// Play from the Stopped state
player.Play();

Console.ReadKey();

/*
 * Definition: --------------------------->
The State Pattern is a behavioral design pattern that allows an object to alter its 
behavior when its internal state changes. 
This pattern is particularly useful when an object needs to change its behavior based on 
its internal state, and the transitions between states should be well-defined.


The State Pattern provides a more modular and extensible solution compared to using 
conditional statements. With conditional statements, the code for each state is often 
spread across multiple places, making it harder to maintain and extend. In contrast, 
the State Pattern encapsulates each state's behavior in separate classes, promoting 
better organization and allowing for easier addition of new states. It also avoids 
large switch or if-else statements, making the code more readable and maintainable.


 * Implementation: -----------------------> 
 ---> Step 1: Define the State Interface
 ---> Step 2: Implement Concrete State Classes
 ---> Step 3: Implement the Context Class (AudioPlayer)

 * Real-World Scenario: ------------------> 
Order Processing System:
Consider an order processing system where an order can be in states like "Pending," 
"Shipped," and "Delivered." The behavior of an order, such as confirming the order, 
shipping it, or marking it as delivered, can be encapsulated in different state classes.

Traffic Light System:
A traffic light can be in states like "Red," "Yellow," and "Green." The behavior of a 
traffic light, such as controlling traffic flow, can be encapsulated in state classes. 
The transitions between states correspond to the changing of lights.

Document Editing Software:
In a document editing application, the document can be in states like "Editing," "Saving,"
and "Closed." The behavior related to editing, saving, or closing the document can be 
encapsulated in separate state classes.

Game Character States:
In a video game, a character may have different states such as "Idle," "Running," 
"Jumping," and "Attacking." The behavior of the character can be defined by different state
 classes, making it easier to manage complex character behaviors.

Vending Machine:
A vending machine can have different states such as "Idle," "AcceptingCoins," 
"DispensingItem," and "OutOfStock." Each state corresponds to the different phases of 
interaction with the vending machine, and behavior can be encapsulated accordingly.

Network Connection:
In a network communication system, a connection can be in states like "Connected," 
"Disconnected," and "Reconnecting." The behavior related to sending, receiving, 
or handling connection issues can be encapsulated in different state classes.

Elevator System:
An elevator can be in states such as "MovingUp," "MovingDown," and "Stopped." The behavior
of the elevator, including opening/closing doors, moving between floors, can be implemented
using the State Pattern.

*/
