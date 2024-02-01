namespace _01_Observer
{
    // Observer interface
    public interface IObserver
    {
        void Update(string temperature, string humidity, string pressure);
    }
    // Subject interface
    public interface IWeatherStation
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
