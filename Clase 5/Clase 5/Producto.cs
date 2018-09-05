using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase_5
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;
        private bool prueba;

        public Producto(string marca, string codigoDeBarra)
        {
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarra;
        }

        public Producto(string marca, bool prueba)
        {
            this.marca = marca;
            this.prueba = prueba;
        }

        public Producto(string marca, string codigoDeBarra, float precio) : this(marca, codigoDeBarra)
        {
            this.precio = precio;
        }

        public static explicit operator string (Producto producto)
        {
            return producto.codigoDeBarra;
        }

        public static bool operator ==(Producto producto1, Producto producto2)
        {
            return (producto1.marca == producto2.marca && producto1.codigoDeBarra == producto2.codigoDeBarra);
            
        }
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        public static bool operator ==(Producto producto1, string producto2)
        {
            return (producto1.marca == producto2);
        }
        public static bool operator !=(Producto producto1, string producto2)
        {
            return !(producto1.marca == producto2);
        }
        public string GetMarca(Producto producto)
        {
            return producto.marca;
        }

        public float GetPrecio(Producto producto)
        {
            return producto.precio;

        }

        public string Mostrar(Producto producto)
        {

            return string.Format("Codigo: {0}\n Marca: {1}\n Precio: {2}", producto.codigoDeBarra, producto.marca, producto.precio);

        }


    }
}
