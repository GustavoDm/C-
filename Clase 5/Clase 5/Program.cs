using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Producto producto = new Producto("pepe", "paco", 15);

            string pepe;
            pepe = (string)producto;
        }

    }
    
}
