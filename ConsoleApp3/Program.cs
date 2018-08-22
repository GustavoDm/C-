using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";

            int num;
            int numMax = int.MinValue;
            int numMin = int.MaxValue;
            float promedio = 0;
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero:");
                num = int.Parse(Console.ReadLine());
                if (numMin > num)
                    numMin = num;
                if (numMax < num)
                    numMax = num;
                promedio += num;
            }
            Console.WriteLine("El numero max es: " + numMax + "\nEl numero minimo es: " + numMin);
            Console.WriteLine("\nEl promedio es: " + promedio / 5);
            Console.ReadKey();
        }
    }
}
