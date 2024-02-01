using _09_Visitor;

Console.WriteLine("09_Visitor:");

// Create shapes
var circle = new Circle(5);
var square = new Square(4);

// Create visitor
var areaCalculator = new AreaCalculator();

// Accept the visitor to calculate the area
circle.Accept(areaCalculator);
square.Accept(areaCalculator);

Console.ReadKey();

/*
 * Definition: --------------------------->
The Visitor Pattern is a behavioral design pattern that allows you to separate algorithms
from the objects on which they operate. It enables you to define new operations on the
objects without modifying their structure.

The Visitor Pattern adheres to the open/closed principle by allowing you to introduce 
new operations (visitors) without modifying the existing element classes. 
New functionality can be added by creating new visitors, making the pattern well-suited 
for scenarios where the object structure is stable, but there is a need to 
extend or modify the behavior.


The Visitor Pattern and the Strategy Pattern both belong to the behavioral design patterns,
 but they serve different purposes. The Visitor Pattern is used to define new operations 
on an object structure without changing its classes, whereas the Strategy Pattern is used
to define a family of algorithms, encapsulate each algorithm, and make them 
interchangeable. 
The key difference lies in the intent and the relationship between the patterns: 
Visitor focuses on operations related to a specific structure, 
while Strategy focuses on algorithmic strategies.


 * Implementation: -----------------------> 
 ---> Step 1: Define the Shape interface and concrete implementations
 ---> Step 2: Define the Visitor interface and concrete implementations
 ---> Step 3: Implement a client to use the Visitor Pattern

 * Real-World Scenario: ------------------> 
Document Processing:
Scenario: Consider a document processing system where you have different document elements
like paragraphs, images, and tables.
Application of Visitor Pattern: You can use the Visitor Pattern to perform operations like
word counting, spell checking, or resizing images without modifying the document element 
classes.

Compiler Design:
Scenario: In a compiler, you have an abstract syntax tree (AST) representing the program
structure.
Application of Visitor Pattern: Implementing a visitor for type checking, code generation,
or optimization allows you to keep these concerns separate from the AST nodes.

GUI Components:
Scenario: You have a graphical user interface with various UI components like buttons, 
text fields, and checkboxes.
Application of Visitor Pattern: Implementing a visitor can help perform operations like 
rendering, event handling, or validation on each UI component.

Financial Systems:
Scenario: In a financial system, you may have different financial instruments like stocks,
bonds, and options.
Application of Visitor Pattern: You can use the Visitor Pattern to calculate the present 
value, perform risk analysis, or generate financial reports without modifying the 
instrument classes.

Medical Information System:
Scenario: In a medical information system, there might be different types of medical 
records, such as patient records, test results, and prescriptions.
Application of Visitor Pattern: Applying a visitor pattern can help you implement 
operations like generating statistics, printing reports, or validating medical records 
without changing the existing record classes.

Network Protocol Processing:
Scenario: When processing network protocols, you may have different types of packets or 
messages.
Application of Visitor Pattern: Using a visitor, you can implement operations like packet
filtering, encryption, or compression without altering the packet classes.


Advantages:

Modularity: Operations are encapsulated in visitor classes, promoting modularity.
Extensibility: New operations can be added without modifying existing classes.
Clean Separation of Concerns: The object structure and algorithms are decoupled.

Drawbacks:

Complexity: Introducing the pattern can lead to a more complex codebase.
Dependency on Object Structure: Changes in the object structure may require modifications 
to all visitor implementations.


*/
