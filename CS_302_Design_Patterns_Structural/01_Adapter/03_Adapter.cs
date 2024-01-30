namespace _01_Adapter
{
    public class TemperatureAdapter : ITemperatureSensor
    {
        private readonly FahrenheitThermometer fahrenheitThermometer;

        public TemperatureAdapter(FahrenheitThermometer fahrenheitThermometer)
        {
            this.fahrenheitThermometer = fahrenheitThermometer;
        }

        public double GetTemperatureInCelsius()
        {
            // Convert Fahrenheit to Celsius and return
            double temperatureInFahrenheit = fahrenheitThermometer.GetTemperatureInFahrenheit();
            double temperatureInCelsius = (temperatureInFahrenheit - 32) * 5 / 9;
            return temperatureInCelsius;
        }

        public double GetTemperatureInFahrenheit()
        {
            return fahrenheitThermometer.GetTemperatureInFahrenheit();
        }
    }
}
