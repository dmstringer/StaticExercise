using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(50);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(30);

            Console.WriteLine($"50 degrees Fahrenheit is {celsius} Celcius."); // should be 10
            Console.WriteLine($"30 degrees Celcius is {fahrenheit} Fahrenheit."); // should be 86
        }
    }
}
