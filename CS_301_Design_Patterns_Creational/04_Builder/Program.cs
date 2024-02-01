using _04_Builder;

Console.WriteLine("----> 04_Builder:");

// Using the builder pattern
IEmailBuilder builder = new EmailBuilder();
Email email = builder.SetSender("sender@example.com")
                     .SetRecipient("recipient@example.com")
                     .SetSubject("Greetings")
                     .SetBody("Hello, how are you?")
                     .Build();

Console.WriteLine(email);

// Using the director (optional)
EmailDirector director = new EmailDirector();
Email anotherEmail = director.ConstructEmail(builder, "another.sender@example.com", "another.recipient@example.com", "Meeting", "Let's schedule a meeting.");
Console.WriteLine(anotherEmail);


/*
 * Definition: ----------------------->
 The Builder Pattern is a creational design pattern that is used for constructing 
a complex object step by step. 
It allows you to produce different types and representations of an object 
using the same construction process. 

This pattern is particularly useful 
when an object has a large number of possible configurations, 
and you want to make the construction process more flexible and readable.

 * Implementation: -----------------------> 
---> Step 1: Create the Product Class (Email) 
---> Step 2: Create the Builder Interface (IEmailBuilder)
---> Step 3: Implement the Concrete Builder (EmailBuilder)
---> Step 4: Create the Director (Optional) -- can create object directly without using Director class

*/