using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    public class Dolar
    {
        private double cantidad;
        private double cotizRespectoDolar;

        public double Cantidad
        {
           /* get { return this.cantidad; }
            set
            {
                this.cantidad = value >= 0 ? value : 0;
                //if(value >= this.cantidad)
                //    this.cantidad = value;
                //else 
                    this.cantidad = value;                
            }*/
        }


        private Dolar()
        {
            this.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizRespectoDolar) : this(cantidad)
        {
            this.cotizRespectoDolar = cotizRespectoDolar;
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        public static explicit operator Pesos(Dolar dolar)
        {
            return new Pesos(dolar.cantidad * Pesos );
        }
        public static double GetCantidad(Dolar dolars)
        {
            return dolars.cantidad;
        }

        public double GetCotizacion(Dolar dolars)
        {
            return dolars.cotizRespectoDolar;
        }
    }
}
