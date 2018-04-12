using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currenDis = new CurrentConditionDisplay(weatherData);
            StaticsDisplay staticDis = new StaticsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 33.4f);
            weatherData.SetMeasurements(55, 55, 31.4f);
            weatherData.SetMeasurements(85, 66, 43.4f);

            Console.ReadKey();
        }
    }
}
