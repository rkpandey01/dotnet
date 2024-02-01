using _05_Prototype;

Console.WriteLine("----> 05_Prototype:");

// Create prototypes
IShape circlePrototype = new Circle(5);
IShape squarePrototype = new Square(4);

// Clone and customize shapes
IShape clonedCircle = circlePrototype.Clone();
IShape clonedSquare = squarePrototype.Clone();

// Draw the cloned shapes
clonedCircle.Draw();
clonedSquare.Draw();

// Modify the cloned shapes if needed
((Circle)clonedCircle).Draw(); // Casting to access specific methods/properties

Console.ReadLine();

/*
 * Definition: ----------------------->
The Prototype pattern is a creational design pattern that involves creating new objects 
by copying an existing object, known as the prototype. 

This pattern is useful when the cost of creating an object is more expensive or complex 
than copying an existing one. The Prototype pattern is implemented by creating a clone 
of an existing object, and then customizing it as needed.



 * Implementation: -----------------------> 
---> Step 1: Define the prototype interface (Cloneable)
---> Step 2: Implement the concrete prototype class (Shape)
---> Step 3: Implement concrete classes (Circle and Square)


 * MemberwiseClone: -----------------------> 
It is used to create a shallow copy of an object. 
A shallow copy means that the new object is a copy of the original object, 
but the individual elements within the object (such as fields or properties) are not duplicated.
The class you want to clone must implement the ICloneable interface, which includes a Clone method. 

No Constructors Invoked in MemberwiseClone method. It does not invoke the constructors of the object 
being cloned or any of its contained objects. It directly copies the field values.

Shallow Copy: The method creates a new object and copies the values of all fields 
from the original object to the new object. If the fields are reference types, 
the references themselves are copied (not the objects they point to).
The original and copied objects share references to the same underlying objects.
Changes to the shared objects will be reflected in both the original and the copied objects.

Deep Copy:
Definition: A deep copy creates a new object and recursively copies all objects referenced by 
the original object. It ensures that the entire object hierarchy is duplicated, 
resulting in separate objects that are independent of each other.
involves manually implementing the copy logic or using serialization/deserialization techniques. 


*/