using _02_Strategy;

Console.WriteLine("02_Strategy:");
Console.WriteLine("Ex 01: --------------------------------");
// Create characters with different attack strategies
Character warrior = new Character(new SwordAttackStrategy());
Character archer = new Character(new BowAttackStrategy());
Character wizard = new Character(new FireballAttackStrategy());

// Perform attacks
warrior.Attack();  // Output: Attacking with a sword!
archer.Attack();   // Output: Attacking with a bow and arrow!
wizard.Attack();   // Output: Casting fireball spell!

// Change attack strategy at runtime
wizard.SetAttackStrategy(new SwordAttackStrategy());
wizard.Attack();   // Output: Attacking with a sword!

Console.WriteLine("Ex 02: --------------------------------");

// Create a data processor with different storage strategies
DataProcessor highPerformanceProcessor = new DataProcessor(new InMemoryStorageStrategy());
DataProcessor reliableProcessor = new DataProcessor(new DatabaseStorageStrategy());
DataProcessor costEffectiveProcessor = new DataProcessor(new CloudStorageStrategy());

// Process and store data
highPerformanceProcessor.ProcessAndStoreData("High-performance data");  // Output: Storing data in memory: High-performance data
reliableProcessor.ProcessAndStoreData("Reliable data");                // Output: Storing data in the database: Reliable data
costEffectiveProcessor.ProcessAndStoreData("Cost-effective data");     // Output: Storing data in the cloud: Cost-effective data

// Change storage strategy at runtime
reliableProcessor.SetStorageStrategy(new InMemoryStorageStrategy());
reliableProcessor.ProcessAndStoreData("Updated strategy data");       // Output: Storing data in memory: Updated strategy data

Console.ReadKey();

/*
 * Definition: --------------------------->
The Strategy Pattern is a behavioral design pattern that defines a family of algorithms,
encapsulates each algorithm, and makes them interchangeable. 
It allows the client to choose an algorithm from a family of algorithms at runtime. 
The main idea is to define a family of algorithms, encapsulate each algorithm, 
and make them interchangeable.

 * Implementation: -----------------------> 
 ---> Step 1: Define the Strategy Interface
 ---> Step 2: Implement Concrete Strategies
 ---> Step 3: Create a Context Class

 * Real-World Scenario: ------------------> 
Consider a payment processing system where different payment methods (credit card, 
PayPal, and cryptocurrency) need to be supported. 
The Strategy Pattern can be applied by defining a common interface (IPaymentStrategy) 
and implementing concrete strategies (CreditCardPaymentStrategy, PayPalPaymentStrategy,
CryptocurrencyPaymentStrategy). The payment processing system can then use different
payment strategies interchangeably based on user preferences or system requirements.

Benefits of the Strategy Pattern:

Flexibility: The Strategy Pattern allows easy interchangeability of algorithms, 
making it flexible to add, remove, or modify strategies without affecting the client.
Readability: It improves code readability by separating concerns and promoting a clean,
modular design.
Testability: Each strategy can be tested independently, promoting better unit testing.

Drawbacks of the Strategy Pattern:

Complexity: For small, simple systems, applying the Strategy Pattern might introduce
unnecessary complexity.
Increased Number of Classes: Implementing the pattern may lead to a larger number of 
classes, especially if there are many strategies, which could make the codebase more 
challenging to manage.

*/
