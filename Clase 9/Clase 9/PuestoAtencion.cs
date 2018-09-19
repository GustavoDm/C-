using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Clase_9
{
    public enum Puesto
    {
        Caja1,
        Caja2,
    }
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }


        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        public bool Atender(Cliente cliente)
        {
            if (cliente != null)
            {
                Random r = new Random();
                int aleatorio = r.Next(1000, 3000);
                Thread.Sleep(aleatorio);
                return true;
            }
            else
                return false;
        }


    }
}
