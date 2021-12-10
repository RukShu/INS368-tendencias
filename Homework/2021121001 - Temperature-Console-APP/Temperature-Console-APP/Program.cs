using System;
using Temperature_Conversion_API;

namespace Temperature_Console_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.Write("Usage:\n\nTemperature_Console_APP [Degrees] [Initial Scale] [End Scale]\n");
                return;
            }

            for(int i = 0; i < args[0].Length; i++)
            {
                if(!Char.IsDigit(args[0][i]) && args[0][i] != '.')
                {
                    Console.WriteLine("Error: Degrees should be a number.");
                    return;
                }
            }
            Temperature temp;
            switch (args[1])
            {
                case "C":
                    temp = new Temperature(double.Parse(args[0]), TemperatureScale.Celsius);
                    break;
                case "F":
                    temp = new Temperature(double.Parse(args[0]), TemperatureScale.Fahrenheit);
                    break;
                case "K":
                    temp = new Temperature(double.Parse(args[0]), TemperatureScale.Kelvin);
                    break;
                default:
                    Console.WriteLine("Error: Initial Temperature Scale not supported.");
                    return;
            }

            switch (args[2])
            {
                case "C":
                    Console.WriteLine(temp.toCelsius().degrees);
                    break;
                case "F":
                    Console.WriteLine(temp.toFahrenheit().degrees); 
                    break;
                case "K":
                    Console.WriteLine(temp.toKelvin().degrees); 
                    break;
                default:
                    Console.WriteLine("Error: End Temperature Scale not supported.");
                    return;
            }

        }
    }
}
