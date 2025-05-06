using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente : Persona
    {
        public string telefono { get; set; }
        public string email { get; set; }

        public Cliente(string nombre, string apellido, string cedula, string telefono, string email)
        : base(nombre, apellido, cedula)
        {
            this.telefono = telefono;
            this.email = email;
        }

        public override string ToString()
        {
            return $"Cliente [{base.ToString()} telefono={telefono}, correo={email}]";
        }
    }
}