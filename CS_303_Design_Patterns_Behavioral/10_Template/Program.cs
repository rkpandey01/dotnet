using _10_Template;

Console.WriteLine("10_Template:");

Console.WriteLine("Making tea:");
BeverageTemplate tea = new Tea();
tea.MakeBeverage();

Console.WriteLine("\nMaking coffee:");
BeverageTemplate coffee = new Coffee();
coffee.MakeBeverage();

Console.ReadKey();

/*
 * Definition: --------------------------->
The Template Pattern is a behavioral design pattern that defines the skeleton of 
an algorithm in the superclass but lets subclasses override specific steps of the 
algorithm without changing its structure. It is a way to define a template or blueprint 
for an algorithm and allow subclasses to provide concrete implementations 
for certain steps.

 * Implementation: -----------------------> 
 ---> Step 1: Define the abstract class with the template method and abstract methods for specific steps.
 ---> Step 2: Create concrete subclasses for specific beverages (e.g., Tea and Coffee) by extending the abstract class and implementing the specific steps.
 ---> Step 3: Use the template method in the client code to make different beverages.

 * Real-World Scenario: ------------------> 
Web Frameworks:
In web development frameworks, template patterns are commonly used. For instance, 
consider the process of handling HTTP requests. There might be a common structure for 
handling requests, but the specific actions taken for different types of requests 
(GET, POST, etc.) can vary. The framework could define a template method, and specific
implementations (subclasses) would handle the details.

Document/Report Generation:
In document generation systems, you may have a common template for creating documents, 
but the content and formatting can vary. The template defines the overall structure, and
subclasses implement specific sections or details.

Game Development:
In game development, especially in game engines, you might have a game loop that includes
common steps like updating entities, handling input, and rendering. The template pattern 
can be used to define the overall game loop structure, while specific implementations in 
subclasses handle the unique behaviors of different types of games.

Workflow Engines:
Workflow engines often involve a series of steps that need to be executed in a specific 
order. The template pattern can be applied to define a generic workflow template, with 
subclasses implementing the specific actions to be taken at each step.

Database Access:
When working with databases, there may be a common structure for querying or updating data.
 The template pattern can be applied to define the overall database access algorithm, 
while specific implementations handle the details of different database systems or query
types.

Testing Frameworks:
Testing frameworks can use the template pattern to define the overall testing process. 
The template method could include steps like setup, execution, and teardown, 
while subclasses provide specific test cases or testing strategies.

*/
