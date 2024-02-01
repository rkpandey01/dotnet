using _03_Command;
using System;

Console.WriteLine("03_Command:");
Console.WriteLine("Ex 01: --------------------------------");
// Create instances of the receiver and commands
Light light = new Light();
ICommand turnOnCommand = new TurnOnCommand(light);
ICommand turnOffCommand = new TurnOffCommand(light);

// Create an invoker and associate it with commands
RemoteControl remote = new RemoteControl();
remote.SetCommand(turnOnCommand);

// Press the button to turn the light on
remote.PressButton(); // Output: Light is ON

// Change the command to turn the light off
remote.SetCommand(turnOffCommand);

// Press the button to turn the light off
remote.PressButton(); // Output: Light is OFF
Console.WriteLine("Ex 02: --------------------------------");
// Create an instance of the receiver (Document Processor)
DocumentProcessor documentProcessor = new DocumentProcessor();

// Create instances of concrete command classes
ICommand2 saveCommand = new SaveCommand(documentProcessor);
ICommand2 printCommand = new PrintCommand(documentProcessor);
ICommand2 undoCommand = new UndoCommand(documentProcessor);

// Create an invoker (User)
User user = new User();

// Perform save operation
user.SetCommand(saveCommand);
user.ExecuteOperation();

// Perform print operation
user.SetCommand(printCommand);
user.ExecuteOperation();

// Perform undo operation
user.SetCommand(undoCommand);
user.ExecuteOperation();

Console.ReadKey();

/*
 * Definition: --------------------------->
The Command Pattern is a behavioral design pattern that turns a request into 
a stand-alone object containing all information about the request. 
This object can be passed around, stored, and executed later. 
It allows you to decouple sender and receiver objects by encapsulating a request as 
an object, thereby allowing for parameterization of clients with different requests,
queuing of requests, and logging of the commands.

The Command Pattern decouples the sender (Invoker) of a request from the object 
that performs the request (Receiver). 
It achieves this by allowing commands to be parameterized and stored as objects, 
which can be passed between objects. This separation reduces the dependency 
between the sender and receiver, promoting flexibility and extensibility.

 * Implementation: -----------------------> 
 ---> Step 1: Define the Command Interface
 ---> Step 2: Create Concrete Command Classes
 ---> Step 3: Create the Receiver Class
 ---> Step 4: Create the Invoker Class

 * Real-World Scenario: ------------------> 

ne real-world example is a remote control for electronic devices. The remote control
(Invoker) sends commands (ConcreteCommand) to various devices (Receiver) like TVs or
stereos. New devices and commands can be added without modifying the remote control,
illustrating the flexibility of the Command Pattern.

*/
