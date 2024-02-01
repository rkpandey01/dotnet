using _01_Observer;

Console.WriteLine("01_Observer:");

WeatherStation weatherStation = new WeatherStation();

CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
ForecastDisplay forecastDisplay = new ForecastDisplay();

// Register observers with the weather station
weatherStation.RegisterObserver(currentConditionsDisplay);
weatherStation.RegisterObserver(statisticsDisplay);
weatherStation.RegisterObserver(forecastDisplay);

// Simulate new weather measurements, which will notify the observers
weatherStation.SetMeasurements("25°C", "60%", "1010hPa");

// Unregister an observer
weatherStation.RemoveObserver(statisticsDisplay);

// Simulate new weather measurements again, only remaining observers should be notified
weatherStation.SetMeasurements("28°C", "55%", "1005hPa");

Console.WriteLine("Ex 02: --------------------------------");

LoggingService loggingService = new LoggingService();

ConsoleLogger consoleLogger = new ConsoleLogger();
EmailNotifier emailNotifier = new EmailNotifier();

// Register observers with the logging service
loggingService.RegisterObserver(consoleLogger);
loggingService.RegisterObserver(emailNotifier);

// Simulate logging events, which will notify the observers
loggingService.LogEvent("Error: Database connection lost.");

// Unregister an observer
loggingService.RemoveObserver(consoleLogger);

// Simulate another logging event, only the remaining observer should be notified
loggingService.LogEvent("Info: Application started successfully.");

Console.WriteLine("Ex 03: Pull model----------------------");

PullWeatherStation weatherStation2 = new PullWeatherStation();

PullWeatherDisplay display1 = new PullWeatherDisplay();
PullWeatherDisplay display2 = new PullWeatherDisplay();

// Register displays with the weather station
weatherStation2.RegisterObserver(display1);
weatherStation2.RegisterObserver(display2);

// Simulate weather updates, displays pull the information they need
weatherStation2.UpdateWeather("Sunny", 28.5);
weatherStation2.UpdateWeather("Cloudy", 22.0);

Console.ReadKey();

/*
 * Definition: --------------------------->
The Observer Pattern is a behavioral design pattern where an object, known as the subject,
maintains a list of its dependents, called observers, that are notified of any changes 
in the subject's state. 

This pattern is useful when you have a one-to-many relationship between objects, 
and changes to one object need to be propagated to multiple other objects 
without them being tightly coupled. 

This pattern is widely used to implement distributed event handling systems

Use Lock  for Thread-safe.

Two types ---- Pull and Push
In the push model, the subject sends detailed information to observers, 
while in the pull model, the subject only notifies observers, 
and they retrieve the necessary information if needed. 
Both models achieve the same goal of updating observers when the state changes, 
but the push model sends data to observers, while the pull model lets observers 
fetch the data as needed.


 * Implementation: -----------------------> 
 ---> Step 1: Define Subject and Observer Interfaces
 ---> Step 2: Implement Concrete Subject
 ---> Step 3: Implement Concrete Observers

 * Real-World Scenario: ------------------> 
Implementing a weather monitoring system with multiple displays.
Creating a logging system where different components need to react to log events.
Developing a GUI framework where UI elements need to update based on changes in underlying data.

*/
