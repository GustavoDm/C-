using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
   public class Pesos
    {
        private double cantidad;
        private double cotizRespectoDolar;
        
        private Pesos()
        {
            this.cotizRespectoDolar = 17.55;
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizRespectoDolar) : this(cantidad) 
        {
            this.cotizRespectoDolar = cotizRespectoDolar;
        }

        public static implicit operator Pesos(double cantidad)
        {
            return  new Pesos(cantidad);
        }

        public static explicit operator Euro(Pesos pesos)
        {
            return new Euro(pesos.cantidad * (pesos.cotizRespectoDolar / 1.3642));
        }

        public static explicit operator Dolar(Pesos pesos)
        {
            return new Dolar(pesos.cantidad / pesos.cotizRespectoDolar);
        }

        public static double GetCantidad(Pesos pesos)
        {
            return pesos.cantidad;
        }

        public static double GetCotizacion(Pesos pesos)
        {
            return pesos.cotizRespectoDolar;
        }

        public static bool operator ==(Pesos pesos1, Pesos pesos2)
        {
            return (pesos1.cantidad == pesos2.cantidad);
        }
        
        public static bool operator !=(Pesos pesos1, Pesos pesos2)
        {
            return !(pesos1.cantidad == pesos2.cantidad);
        }

        public static bool operator ==(Pesos pesos, Dolar dolars)
        {
            return (pesos.cantidad == dolars.cantidad);
        }
    }
}
