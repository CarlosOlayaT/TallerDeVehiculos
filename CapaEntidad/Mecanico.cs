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


        public Mecanico(string nombre, string apellido, string cedula, string especialidad, int aniosExperiencia) : base( nombre,  apellido,  cedula)
        {
            this.Especialidad= especialidad;
            this.AniosExperiencia= aniosExperiencia;
        }

        public override string ToString()
        {
            return $"Mecanico| {base.ToString()} Especialidad: {Especialidad}, Años de experiencia: {AniosExperiencia}";
        }
        
    }
}
