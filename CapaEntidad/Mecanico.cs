using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Mecanico : Persona
    {

        public string Especialidad { get; set; }
        public int AniosExperiencia { get; set; }
        public bool Estado { get; set; } = true;

        public Servicio Servicio
        {
            get => default;
            set
            {
            }
        }

        public Mecanico(string nombre, string apellido, string cedula, string telefono, string especialidad, int aniosExperiencia) : base(nombre, apellido, cedula, telefono)
        {
            this.Especialidad = especialidad;
            this.AniosExperiencia = aniosExperiencia;
        }
        public Mecanico() : base()
        {

        }

        public override string ToString()
        {
            return $" {base.ToString()}";
        }

    }
}
