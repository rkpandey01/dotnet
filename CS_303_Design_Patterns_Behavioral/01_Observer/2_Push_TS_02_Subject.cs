namespace _01_Observer
{
    // ConcreteSubject class
    public class LoggingService : ILoggingService
    {
        private List<ILogObserver> observers = new List<ILogObserver>();
        private readonly object lockObject = new object(); // Lock object to ensure thread safety


        public void RegisterObserver(ILogObserver observer)
        {
            lock (lockObject)
            {
                observers.Add(observer);
            }
        }

        public void RemoveObserver(ILogObserver observer)
        {
            lock (lockObject)
            {
                observers.Remove(observer);
            }
        }

        public void NotifyObservers(string logMessage)
        {
            lock (lockObject)
            {
                foreach (var observer in observers)
                {
                    observer.LogUpdate(logMessage);
                }
            }
        }

        // Simulate logging an event
        public void LogEvent(string logMessage)
        {
            Console.WriteLine($"LoggingService: {logMessage}");
            NotifyObservers(logMessage);
        }
    }

}
