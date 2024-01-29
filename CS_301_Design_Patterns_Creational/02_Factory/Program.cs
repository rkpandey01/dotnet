using _02_Factory;

Console.WriteLine("----> 02_Factory:");


ShapeFactory shapeFactory = new ShapeFactory();

// Get an object of Circle and call its Draw method
IShape circle = shapeFactory.GetShape("circle");
circle.Draw();

// Get an object of Rectangle and call its Draw method
IShape rectangle = shapeFactory.GetShape("rectangle");
rectangle.Draw();


/*
 * Definition: ----------------------->
The Factory Design Pattern is a creational pattern that provides an interface 
for creating objects in a super class, but allows subclasses to alter the type of objects 
that will be created. This pattern involves an interface, a concrete class, 
and a factory class that creates objects based on this interface. 
The Factory Design Pattern is particularly useful when you have a superclass 
with multiple subclasses and, based on input conditions, 
you need to return one particular subclass instance.

 * Implementation: -----------------------> 
---> Step 1: Create an interface 
---> Step 2: Create concrete classes implementing the interface 
---> Step 3: Create a factory class to generate object of concrete classes based on given information
public class ShapeFactory




Advantages of Factory Design Pattern:

Encapsulation of Object Creation:
The Factory Design Pattern encapsulates the object creation logic within a dedicated class (the factory). This helps in isolating the client code from the details of object creation, promoting a cleaner and more maintainable codebase.

Flexibility and Extensibility:
It provides a flexible way to create objects by allowing subclasses to alter the type of objects that will be created. This makes it easy to introduce new classes without modifying existing client code, promoting extensibility.

Centralized Control:
The factory class centralizes the object creation process, providing a single point of control. This can be beneficial for managing and maintaining the creation logic, especially in complex systems with multiple object types.

Code Reusability:
The Factory Design Pattern promotes code reusability by encapsulating the creation logic in a separate class. This class can be reused across different parts of the application or even in different applications.

Reduced Dependency:
Client classes depend on the factory interface or abstract class rather than the concrete classes. This reduces the dependency on specific implementations, making it easier to switch between different implementations without affecting the client code.


Disadvantages of Factory Design Pattern:

Increased Number of Classes:
Implementing the Factory Design Pattern often leads to an increase in the number of classes in the codebase. For simple cases, the additional classes may seem unnecessary and can introduce some overhead.

Complexity for Small Systems:
In small systems or simple scenarios, using a Factory Design Pattern may introduce unnecessary complexity. The overhead of creating factories and interfaces may outweigh the benefits in such cases.

Runtime Overhead:
Some implementations of the Factory Design Pattern may incur runtime overhead, especially if the factory needs to perform complex logic to determine the type of object to create. This can impact performance in certain scenarios.

Tight Coupling with Concrete Classes:
In some implementations, the client code may become tightly coupled with specific concrete classes if the factory exposes concrete class names or if the creation logic is tightly bound to the client code.










*/
