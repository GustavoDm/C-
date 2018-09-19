using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private string nombre;
        private Queue<Cliente> clientes;
        
        
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
        }

        private Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            set
            {
                bool agregado = this + value;
            }
            get
            {
                return this.clientes.Dequeue();
            }
        }

        public  static bool operator +(Negocio n, Cliente c)
        {

            bool seAgrego;
            if (n == c)
                seAgrego = false;
            else
            {
                n.clientes.Enqueue(c);
                seAgrego = true;
            }
            return seAgrego;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
           
           foreach(Cliente i in n.clientes)
            {
                if (c == i)
                    return true;  
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            
        }
            

    }
}
