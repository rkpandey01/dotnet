namespace _01_Observer
{
    // Pull Model
    // Observer interface
    public interface IPullWeatherDisplay
    {
        void Update(IPullWeatherStation subject);
    }

    // Subject interface
    public interface IPullWeatherStation
    {
        void RegisterObserver(IPullWeatherDisplay observer);
        void RemoveObserver(IPullWeatherDisplay observer);
        void NotifyObservers();
    }
}
