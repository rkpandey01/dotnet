using _06_Proxy;

Console.WriteLine("06_Proxy:");

//Example 1 ----------------------------

// Using RealDatabase directly
IDatabase realDatabase = new RealDatabase();
realDatabase.ExecuteQuery("SELECT * FROM Users");

Console.WriteLine();

// Using ProxyDatabase to control access to RealDatabase
IDatabase proxyDatabase = new ProxyDatabase();
proxyDatabase.ExecuteQuery("SELECT * FROM Products");
proxyDatabase.ExecuteQuery("SELECT * FROM Users");
proxyDatabase.ExecuteQuery("SELECT * FROM Products"); // Retrieving from cache

//Example 2 ----------------------------

// Using RealImage directly
IImage realImage = new RealImage("example.jpg");
realImage.Display();

Console.WriteLine();

// Using ProxyImage to control access to RealImage
IImage proxyImage = new ProxyImage("example.jpg");
proxyImage.Display();

Console.ReadKey();

/*
 * Definition: --------------------------->
The Proxy Pattern is a structural design pattern where a surrogate or 
placeholder object controls access to another object. 

This pattern is useful in various scenarios, such as controlling access, logging, 
or providing a virtual representation of an object.

 * Implementation: -----------------------> 
 ---> Step 1: Define the main interface
 ---> Step 2: Implement the main interface -- Real class
 ---> Step 3: Implement the main interface -- Proxy class and set control for real 

 * Real-World Scenario: ------------------> 
Benefits of Using Proxy Pattern:

Lazy Loading: The Proxy can delay the creation and initialization of the RealSubject until 
it is actually needed, improving performance.

Access Control: The Proxy can control access to the RealSubject by adding authentication 
or authorization checks.

Logging: The Proxy can log method calls, helping with debugging or performance monitoring 
without modifying the RealSubject.

In conclusion, the Proxy Pattern is a useful design pattern for scenarios where you need to control access, add functionality, 
or provide a virtual representation of an object.

*/