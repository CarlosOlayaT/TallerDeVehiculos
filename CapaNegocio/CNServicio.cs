using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNServicio
    {

        public static void AgregarServicio(Servicio servicio)
        {
            
            if (servicio.mecanico ==null)
            {
                throw new ArgumentException("El mecanico no puede ser nulo");
            }

            if (servicio.mecanico ==null)
            {
                throw new ArgumentException("El nombre del cliente esta vacio");
            }

            if (servicio.precio <= 0)
            {
                throw new ArgumentOutOfRangeException("El precio debe ser mayor a 0");
            }

            if (string.IsNullOrEmpty(servicio.estado))
            {
                throw new ArgumentException("El estado del servicio esta vacio");
            }

            if (string.IsNullOrEmpty(servicio.descripcion))
            {
                throw new ArgumentException("La descripcion de servicio esta vacia");
            }

            if (servicio.repuestos == null || servicio.repuestos.Count == 0) {
                throw new ArgumentNullException("La lista de repuestos no puede estar vacia");
            }


            CDAlmacenServicio.AgregarServicio(servicio);
        }


        public static void EliminarServicio(Servicio servicio)
        {
            CDAlmacenServicio.RemoverServicio(servicio);
        }

    }
}