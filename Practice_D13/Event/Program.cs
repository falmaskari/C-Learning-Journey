using System.Runtime.InteropServices;
using static Event.Weather;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weather weather = new Weather();
            weather.onWetherChanged += Weather_onWetherChanged;
            weather.changeWeather(16);
            weather.changeWeather(24);
            weather.changeWeather(50);
        }

        private static void Weather_onWetherChanged(Weather weather)
        {
            if (weather.Temperture < 17)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Rainy and cold");
            }
            else if (weather.Temperture > 17 && weather.Temperture < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cloudy and no rain");  
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hot and melt");
            }
            Console.ResetColor();
        }
    }
}
