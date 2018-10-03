using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad
        {
            get
            {
                TimeSpan dias = new TimeSpan();
                dias= DateTime.Now-this.fechaIngreso;
                return dias.Days;
                
            }
        }

        public Profesor(string nombre, string apellido, string documento): base(nombre, apellido,documento)
        {

        }

        public Profesor(string nombre, string apellido, string documento,DateTime fechaIngreso): this(nombre,apellido,documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
    }
}
