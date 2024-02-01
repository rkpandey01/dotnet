namespace _01_Observer
{
    using System.Collections.Generic;

    // ConcreteSubject class
    public class WeatherStation : IWeatherStation
    {
        private List<IObserver> observers = new List<IObserver>();
        private string temperature;
        private string humidity;
        private string pressure;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        // Simulate receiving new weather data
        public void SetMeasurements(string temperature, string humidity, string pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }
    }

}
