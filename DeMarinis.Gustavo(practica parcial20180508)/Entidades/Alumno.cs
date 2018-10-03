using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Alumno : Persona
    {
        short anio;
        Divisiones divisiones;

        public string AnioDivision
        {
            get
            {
                return anio.ToString()+"º"+this.divisiones.ToString();
            }
        }

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones divisiones) :base(nombre, apellido,documento)
        {
            this.anio = anio;
            this.divisiones = divisiones;
        }
    }
}
