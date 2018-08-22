using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {



            bool esNum;
            bool isPrime = true;
            int size;
            Console.Write("Ingrese un numero:");
            esNum = int.TryParse(Console.ReadLine(), out size);
            for (int i = 0; i <= size; i++)
            {
                for (int j = 2; j <= size; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Primo: " + i);
                }
                isPrime = true;
            }

            Console.ReadKey();
        }
    }
}
  

