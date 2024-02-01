namespace _01_Observer
{
    // ConcreteObserver classes
    public class CurrentConditionsDisplay : IObserver
    {
        public void Update(string temperature, string humidity, string pressure)
        {
            Console.WriteLine($"Current Conditions Display: Temperature {temperature}, Humidity {humidity}, Pressure {pressure}");
        }
    }

    public class StatisticsDisplay : IObserver
    {
        public void Update(string temperature, string humidity, string pressure)
        {
            Console.WriteLine($"Statistics Display: Updated with new data - Temperature {temperature}, Humidity {humidity}, Pressure {pressure}");
        }
    }

    public class ForecastDisplay : IObserver
    {
        public void Update(string temperature, string humidity, string pressure)
        {
            Console.WriteLine($"Forecast Display: Conditions suggest a stable weather pattern - Temperature {temperature}, Humidity {humidity}, Pressure {pressure}");
        }
    }

}
