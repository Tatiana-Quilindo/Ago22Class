using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ago22Class
{
    public class Class3
    {
        public static void Ejercicio3()
        {
                Console.WriteLine("Ingrese la temperatura en Celsius:");
                double tempCelsius = double.Parse(Console.ReadLine());

                double tempFahrenheit = (tempCelsius * 9 / 5) + 32;
                Console.WriteLine("Temperatura en Fahrenheit: " + tempFahrenheit.ToString("0.00") + " °F");
        }
    }
}

