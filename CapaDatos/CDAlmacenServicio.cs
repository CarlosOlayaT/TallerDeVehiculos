using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDAlmacenServicio

    {
        public static List<Servicio> AlmacenServicio = new List<Servicio>();

        public static void AgregarServicio(Servicio servicio)
        {
        

            AlmacenServicio.Add(servicio);

        }


        public static void RemoverServicio(Servicio servicio)
        {
            AlmacenServicio.Remove(servicio);
        }


    }

}