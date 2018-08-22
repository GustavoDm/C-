using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
                

            float potencia;
            Console.Write("Ingrese un numero:");
            potencia = float.Parse(Console.ReadLine());
            Console.WriteLine("El cuadrado es: " + Math.Pow(potencia, 2) + "\nEl Cubo es: " + Math.Pow(potencia, 3));
           
            Console.ReadKey();  


        }
    }
}
