using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;


        public string Apellido
        {
            get
            {
                return this.apellido;
            }

        }

        public string Documento
        {
            set
            {
                this.documento = value;
            }
            get
            {
                return this.documento;
            }
        }

        public string Nombre
        {
            get
            {
                return this.documento;
            }
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }
        
        protected virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendFormat("Nombre: {0} Apellido: {1} Documento: {2}", this.nombre, this.apellido, this.documento).ToString();
        }

        protected abstract bool ValidarDocumentacion(string doc); 
    }
}
