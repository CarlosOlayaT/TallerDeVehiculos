using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDAlmacenMecanico 
    {
        public static List<Mecanico> AlmacenMecanico = new List<Mecanico>();


        public static void AgregarMecanico(Mecanico mecanico)
        {
            AlmacenMecanico.Add(mecanico);
            
        }


        public static void RemoverMecanico(Mecanico mecanico)
        {
            AlmacenMecanico.Remove(mecanico);
        }


    }
    
}