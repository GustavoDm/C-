using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8
{
    public class Factura
    {
        
        private int Numero;
        private DateTime Fecha;
        private int Moneda;
        public List<Producto> Productos = new List<Producto>();

        public enum Emoneda
        {
            Dolar,
            Euro,
            Peso,
        }

        public enum Etipodefactura
        {
            A,
            B,
            C,
        }
        public Producto this[int i]
        {
            get
            {
                Producto salida = null;
               foreach (Producto item in Productos)
                {
                    if(item.Identificador==i)
                    {
                        salida = item;
                    }
                }
                return salida;
            }
            set
            {
                bool encontro = false;
                
                    foreach(Producto item in Productos)
                    {
                        if(item.Identificador==i)
                        {
                        item.Cantidad += value.Cantidad;
                        encontro = true;
                        }
                    }
                if (!encontro)
                    this.Productos.Add(value);
                
            }
        }
        public Factura()
        {

        }
        
        public Factura(int Numero, DateTime Fecha, int Moneda, List<Producto> Productos)
        {
            this.Numero = Numero;
            this.Fecha = Fecha;
            this.Moneda = Moneda;
            this.Productos = Productos;
        }

        public double Total
        {
            get
            {
               double total = 0;
                foreach (Producto item in this.Productos)
                {
                    total += item.Total;
                }
                return total;
            }
            
           
        }
    }
}
