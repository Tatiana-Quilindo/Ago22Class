using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ago22Class
{
    public class Class2 
    {
        public static void Ejercicio2()
        {
            Console.WriteLine("Ingrese el total de hombres:");
            int totalHombres = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el total de mujeres:");
            int totalMujeres = int.Parse(Console.ReadLine());

            double porcentajeHombres = (double)totalHombres / (totalHombres + totalMujeres) * 100;
            double porcentajeMujeres = (double)totalMujeres / (totalHombres + totalMujeres) * 100;

            Console.WriteLine("Porcentaje de hombres: " + porcentajeHombres.ToString("0.00") + "%");
            Console.WriteLine("Porcentaje de mujeres: " + porcentajeMujeres.ToString("0.00") + "%");
        }

    }
}

