namespace _01_Observer
{
    public class PullWeatherDisplay : IPullWeatherDisplay
    {
        public void Update(IPullWeatherStation subject)
        {
            if (subject is PullWeatherStation weatherStation)
            {
                string condition = weatherStation.GetWeatherCondition();
                double temperature = weatherStation.GetTemperature();

                Console.WriteLine($"PullWeatherDisplay: Weather condition: {condition}, Temperature: {temperature}°C");
            }
        }
    }
}
