using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Alumno
    {
        private int nota1;
        private int nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;


        public Alumno(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }
        public void Estudiar(Alumno alumno, int nota1, int nota2)
        {
            alumno.nota1 = nota1;
            alumno.nota2 = nota2;
        }
    }
}
