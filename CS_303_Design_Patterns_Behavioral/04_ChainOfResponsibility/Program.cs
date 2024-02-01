using _04_ChainOfResponsibility;

Console.WriteLine("04_ChainOfResponsibility:");

// Create instances of concrete handlers
IApprover teamLead = new TeamLead();
IApprover manager = new Manager();
IApprover director = new Director();

// Set up the chain of responsibility
teamLead.SetNextApprover(manager);
manager.SetNextApprover(director);

// Create a purchase request
PurchaseRequest request1 = new PurchaseRequest("Laptop", 900);
PurchaseRequest request2 = new PurchaseRequest("Projector", 3000);
PurchaseRequest request3 = new PurchaseRequest("Server", 7000);

// Process purchase requests
teamLead.ProcessRequest(request1);
Console.WriteLine();

teamLead.ProcessRequest(request2);
Console.WriteLine();

teamLead.ProcessRequest(request3);

Console.ReadKey();

/*
 * Definition: --------------------------->

The Chain of Responsibility Pattern is a behavioral design pattern where 
a chain of handler objects is created to process a request. 
Each handler in the chain decides either to process the request or to pass it to the 
next handler in the chain. 

This pattern promotes loose coupling and allows multiple objects to handle a request 
without the sender needing to know which object will ultimately process it.

While the Chain of Responsibility can be implemented using a linked list, the pattern 
emphasizes the decoupling of senders and receivers. 
Each handler in the chain can be modified or extended without affecting the others, 
making the pattern more flexible and extensible than a simple linked list.

The pattern promotes loose coupling by allowing each handler to process a request
independently. The client doesn't need to know the specific handler that will process 
the request, and handlers can be added or removed without affecting the client.

 * Implementation: -----------------------> 
 ---> Step 1: Define the Request Class
 ---> Step 2: Define the Handler Interface
 ---> Step 3: Create Concrete Handler Classes
 ---> Step 4: 

 * Real-World Scenario: ------------------> 
Workflow Approval Systems:
In organizations, approval workflows often involve multiple levels of authority. 
For example, a purchase request may need approval from a team lead, manager, and director.
Each level in the hierarchy can be represented by a handler in the chain.

Event Handling Systems:
In graphical user interfaces or game development, events like user input or game commands
often need to be processed by multiple objects. The Chain of Responsibility Pattern can be
used to handle events in a cascading manner.

Logging Systems:
Logging frameworks may have different loggers for various log levels (info, warning,
error). Each logger can be a handler in the chain, and the log entries are passed through
the chain based on their severity.

Middleware in Web Frameworks:
In web frameworks, middleware components often process HTTP requests in a specific order.
Each middleware component can be a handler in the chain, responsible for handling a part 
of the request processing.

Security Systems:
Security systems often have multiple layers of checks. For example, a request may go
through authentication, authorization, and validation layers. Each layer can be a handler
in the chain.

Command Processing Systems:
In command processing systems, commands can be processed by different handlers based on
their type. For example, a document editor may have handlers for copy, cut, paste, etc.

Customer Support Ticketing Systems:
As shown in the previous example, customer support ticketing systems may have different 
handlers for tickets with various priorities. Each handler in the chain processes tickets
based on their priority.

Middleware in Microservices Architectures:
In microservices architectures, requests may need to go through multiple microservices 
for processing. Each microservice can be represented by a handler in the chain.


*/
