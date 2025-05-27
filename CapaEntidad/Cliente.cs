using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente : Persona
    {
        public string email { get; set; }
        public string direccion {  get; set; }

        public Servicio Servicio
        {
            get => default;
            set
            {
            }
        }

        public Cliente(string nombre, string apellido, string cedula, string telefono, string email, string direccion)
        : base(nombre, apellido, cedula, telefono)
        {
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
        }
        public Cliente() : base()
        {

        }
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}