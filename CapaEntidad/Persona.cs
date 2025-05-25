using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public abstract class Persona
    {
        public string cedula { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public DateTime FechaRegistro = DateTime.Now;
        public string telefono { get; set; }

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, string cedula, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.telefono = telefono;
        }

        public override string ToString()
        {
            return $"{nombre} {apellido}";
        }

    }
}