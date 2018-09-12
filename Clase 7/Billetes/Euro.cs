using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    public class Euro
    {
        private double cantidad;
        private double cotizRespectoDolar;

        private Euro()
        {
            this.cotizRespectoDolar = 0.73303042;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizRespectoDolar) : this(cantidad)
        {
            this.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double GetCantidad(Euro euros)
        {
            return euros.cantidad;
        }

        public double GetCotizacion(Euro euros)
        {
            return euros.cotizRespectoDolar;
        }
    }
}
