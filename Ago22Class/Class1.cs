using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ago22Class
{
    public class Class1
    {
        public static void Ejercicio1()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(201);
            Console.WriteLine("Número aleatorio: " + numeroAleatorio);

            double aumento = numeroAleatorio * 1.3;
            Console.WriteLine("Número aumentado en un 30%: " + aumento);
        }
    }
}
