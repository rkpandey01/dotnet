using _03_AbstractFactory;

Console.WriteLine("----> 03_AbstractFactory:");

// Client code for Credit Card
IPaymentProcessorFactory creditCardFactory = new CreditCardPaymentProcessorFactory();
PaymentClient creditCardClient = new PaymentClient(creditCardFactory);
creditCardClient.MakePayment();

Console.WriteLine();

// Client code for PayPal
IPaymentProcessorFactory payPalFactory = new PayPalPaymentProcessorFactory();
PaymentClient payPalClient = new PaymentClient(payPalFactory);
payPalClient.MakePayment();

Console.ReadKey();



/*
 * Definition: ----------------------->
The Abstract Factory Design Pattern is a creational pattern that provides an interface for 
creating families of related or dependent objects without specifying their concrete classes. 
It defines an interface for creating families of related or dependent objects without specifying 
their concrete classes. In other words, it allows you to create objects that are related to 
each other without specifying their exact classes.

 * Implementation: -----------------------> 

---> AbstractFactory: Declares an interface for operations that create abstract products. 
This will be an interface for operations that will create Abstract Product objects.
---> ConcreteFactory: Implements the operations to create concrete product objects. 
These classes implement the Abstract Factory interface and provide implementations for the interface methods. We can use these concrete classes to create concrete product objects.
---> AbstractProduct: Declares an interface for a type of product object. 
These are going to be interfaces for creating abstract products. 
Here, we need to define the Operations a Product should have.
---> ConcreteProduct: Implements the AbstractProduct interface. 
These are the classes that implement the Abstract Product interface.
---> Client: Uses interfaces declared by AbstractFactory and AbstractProduct classes. 
This class will use our Abstract Factory and Abstract Product interfaces 
to create a family of products.



+-------------------------+
|                         |
|   Main Program          |
|                         |
+-----------+-------------+
            |
            | Creates instances of:
            |   - CreditCardPaymentProcessorFactory
            |   - PayPalPaymentProcessorFactory
            |
+-----------v-------------+
|                         |
|   CreditCardPaymentProcessorFactory  |
|                         |
+-----------+-------------+
            |
            | Creates instance of:
            |   - CreditCardPaymentProcessor
            |
+-----------v-------------+
|                         |
|   PaymentClient          |
|                         |
+-----------+-------------+
            |
            | Invokes:
            |   - MakePayment
            |
+-----------v-------------+
|                         |
|   CreditCardPaymentProcessor  |
|                         |
+-------------------------+

*/
