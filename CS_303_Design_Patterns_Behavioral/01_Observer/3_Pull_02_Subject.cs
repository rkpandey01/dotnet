namespace _01_Observer
{
    public class PullWeatherStation : IPullWeatherStation
    {
        private List<IPullWeatherDisplay> displays = new List<IPullWeatherDisplay>();
        private string weatherCondition;
        private double temperature;

        public void RegisterObserver(IPullWeatherDisplay observer)
        {
            displays.Add(observer);
        }

        public void RemoveObserver(IPullWeatherDisplay observer)
        {
            displays.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var display in displays)
            {
                display.Update(this);
            }
        }

        // Simulate weather condition change
        public void UpdateWeather(string condition, double temp)
        {
            weatherCondition = condition;
            temperature = temp;
            NotifyObservers();
        }

        public string GetWeatherCondition()
        {
            return weatherCondition;
        }

        public double GetTemperature()
        {
            return temperature;
        }
    }
}
