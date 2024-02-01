using _02_Decorator;

Console.WriteLine("02_Decorator:");

// Create a plain text
ITextFormatter plainText = new PlainTextFormatter();
Console.WriteLine($"Original Text: {plainText.Format("Hello, world!")}");

// Decorate it with bold formatting
ITextFormatter boldText = new BoldTextDecorator(plainText);
Console.WriteLine($"Formatted Text (Bold): {boldText.Format("Hello, world!")}");

// Decorate it with italic formatting
ITextFormatter italicText = new ItalicTextDecorator(plainText);
Console.WriteLine($"Formatted Text (Italic): {italicText.Format("Hello, world!")}");

// Combine both bold and italic formatting
ITextFormatter boldItalicText = new BoldTextDecorator(new ItalicTextDecorator(plainText));
Console.WriteLine($"Formatted Text (Bold and Italic): {boldItalicText.Format("Hello, world!")}");
    
Console.ReadKey();

/*
 * Definition: --------------------------->
The Decorator Pattern is a structural design pattern that allows behavior to be added 
to an individual object, either statically or dynamically, without affecting the behavior 
of other objects from the same class. 

It is useful for extending the functionalities of classes in a flexible and reusable way.

The Decorator Pattern is aligned with the SOLID principles, 
particularly the Open/Closed Principle, which states that a class should be open for extension 
but closed for modification. 
The Decorator Pattern allows you to extend the behavior of a class without modifying its code, 
thereby adhering to this principle. It also promotes the Single Responsibility Principle 
by separating concerns into distinct classes.

 * Implementation: -----------------------> 
 ---> Step 1: Define the Component Interface
 ---> Step 2: Implement the Concrete Component
 ---> Step 3: Create the Decorator Interface -- abstract class that implements step 1 
 ---> Step 4: Implement Concrete Decorators -- inherited class

 * Real-World Scenario: ------------------> 
One example is a text processing system where you have a basic text component, 
and you want to dynamically add features like bold formatting, italic formatting, etc., 
without modifying the original text component. Each formatting feature can be implemented 
as a decorator, and you can combine them to create different variations of formatted text.

*/