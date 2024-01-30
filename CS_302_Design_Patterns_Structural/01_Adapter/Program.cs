using _01_Adapter;

Console.WriteLine("01_Adapter:");

// Existing code that uses FahrenheitThermometer directly
FahrenheitThermometer fahrenheitThermometer = new FahrenheitThermometer();
double temperatureInFahrenheit = fahrenheitThermometer.GetTemperatureInFahrenheit();
Console.WriteLine($"Temperature in Fahrenheit: {temperatureInFahrenheit}");

// Using Adapter to make FahrenheitThermometer compatible with ITemperatureSensor
ITemperatureSensor temperatureSensor = new TemperatureAdapter(fahrenheitThermometer);
double temperatureInCelsius = temperatureSensor.GetTemperatureInCelsius();
Console.WriteLine($"Temperature in Celsius: {temperatureInCelsius}");
double temperatureInF = temperatureSensor.GetTemperatureInFahrenheit();
Console.WriteLine($"Temperature in Fahrenheit: {temperatureInF}");

Console.ReadKey();


/*
 * Definition: ----------------------->
The Adapter Pattern is a structural design pattern that allows the interface 
of an existing class to be used as another interface. 
It is often used to make existing classes work with others without modifying their source code. 
The adapter acts as a bridge between two incompatible interfaces.

 * Implementation: -----------------------> 
---> Step 1: Add the Adaptee (Existing Class) -- There is no change
---> Step 2: Define the Target Interface (Adapter Interface)
---> Step 3: Implement the Adapter


Real-World Scenario:
Consider a scenario where a company has an existing system that communicates with 
an external service expecting data in a specific format. 
However, the company wants to replace the external service with a new one that has a 
different interface or data format. To achieve this without modifying the existing system, 
the Adapter Pattern can be applied. The adapter acts as an intermediary, 
translating the requests and responses between the existing system and the new service, 
making them compatible.


*/