namespace _01_Observer
{
    // Observer interface
    public interface ILogObserver
    {
        void LogUpdate(string logMessage);
    }
    // Subject interface
    public interface ILoggingService
    {
        void RegisterObserver(ILogObserver observer);
        void RemoveObserver(ILogObserver observer);
        void NotifyObservers(string logMessage);
    }
}
