Console.WriteLine("----> 01_Singleton:");

/*
 * Definition: ----------------------->
In object-oriented programming, the Singleton pattern is a design pattern 
that restricts the instantiation of a class to a single instance 
and provides a global point of access to that instance. 
This is useful when exactly one object is needed to coordinate actions across the system.

 * Implementation: -----------------------> 
---> Declare a private static instance 
---> Make constructor private 
---> Add creation and access point for object
---> create a shared object and lock for thread-safe.

 * Thread Safety Singleton:
The thread is locked on a shared object and checks whether an instance has been created or not. 
In this case performance suffers since a lock is required every time an instance is requested.  


 * Thread Safety Singleton double-check: ----------------------->
While the double-check locking pattern can provide lazy initialization and thread safety,
developers should be aware of historical issues and consider alternative approaches available 
in modern C# versions, such as Lazy<T>, which is designed to handle lazy initialization 
in a thread-safe manner with less boilerplate code.

The double-check locking mechanism provides lazy initialization, 
which means that the singleton instance is created only when it is first needed. 
This can be beneficial for performance because it avoids unnecessary resource allocation 
and initialization if the singleton is never used.

Prior to C# 5.0, the double-check locking pattern was susceptible to a problem known as the 
"double-checked locking problem." In certain situations, due to compiler optimizations 
and memory reordering, it was possible for multiple threads to see a partially constructed instance,
leading to unexpected behavior. This issue was fixed in C# 5.0 and 
later versions with improvements to the volatile keyword and memory model.

 * Lazy<T>: ----------------------->
Thread-safe singleton without using locks.
The Lazy<T> class is designed to handle lazy initialization in a thread-safe manner 
without the need for explicit locks. It internally uses the 
LazyThreadSafetyMode.ExecutionAndPublication mode, which ensures 
that only a single instance is created, even in a multi-threaded environment.

 * Lazy initialization: ----------------------->
 is a programming pattern that defers the creation of an object 
or the execution of a task until it is actually needed. 
The idea is to delay the instantiation or computation until the last possible moment, 
typically when the object or value is requested for the first time. 
This can help improve performance and resource utilization, 
especially when dealing with expensive operations or heavy objects.

In C#, the Lazy<T> class is a built-in mechanism that supports lazy initialization. 
It allows you to create an instance of a class or a value only when it is first accessed. 
The Lazy<T> class takes care of the synchronization and ensures that the initialization 
code is executed only once, even in a multi-threaded environment.

Lazy initialization is particularly useful when dealing with resources that are not always needed 
and would be wasteful to create or load eagerly. 
It's a way to optimize the performance of your application by deferring the cost of initialization
until it's necessary.


*/