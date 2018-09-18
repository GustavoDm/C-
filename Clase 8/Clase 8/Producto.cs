using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8
{
    public class Producto
    {
        private int identificador;
        private string nombre;
        private double precio;
        private double iva;
        private int cantidad;

       

        public Producto(int identificador, string nombre, double precio)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.precio = precio;
            this.iva = precio *0.21;
            this.cantidad = 1;
        }

     public double Precio
        {
            set
            {
                this.precio = value;
                this.iva = this.precio * 0.21;
            }
        }

        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }

        public int Identificador
        {
            set
            {
                this.identificador = value;
            }
            get
            {
                return this.identificador;
            }
        }

        public int Cantidad
        {
            set
            {
                this.cantidad = value;
            }
            get
            {
                return this.cantidad;
            }
        }

        public double Total
        {
            get
            {
                return this.precio + this.iva;
            }
        }
        
        
    }
}
