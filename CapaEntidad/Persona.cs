using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Persona
    {
        public string cedula { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public DateTime FechaRegistro = DateTime.Now;
        
        public Persona(string nombre, string apellido, string cedula)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
        }

        public override string ToString()
        {
            return $"[nombre={nombre}, apellido={apellido}, cedula={cedula}]";
        }

    }
}