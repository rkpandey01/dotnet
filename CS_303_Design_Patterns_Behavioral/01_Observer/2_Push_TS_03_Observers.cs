namespace _01_Observer
{
    // ConcreteObserver classes
    public class ConsoleLogger : ILogObserver
    {
        public void LogUpdate(string logMessage)
        {
            Console.WriteLine($"ConsoleLogger: {logMessage}");
        }
    }

    public class EmailNotifier : ILogObserver
    {
        public void LogUpdate(string logMessage)
        {
            // Simulate sending an email notification with the log message
            Console.WriteLine($"EmailNotifier: Sent email notification - {logMessage}");
        }
    }
}
