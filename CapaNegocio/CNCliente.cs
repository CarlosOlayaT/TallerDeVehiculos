using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNCliente
    {

        public static void AgregarCliente(Cliente cliente)
        {
            //Nombres
            if (string.IsNullOrEmpty(cliente.nombre))
            {
                throw new ArgumentException("El nombre esta vacio");
            }
            if (string.IsNullOrEmpty(cliente.apellido))
            {
                throw new ArgumentException("El apellido esta vacio");
            }
            if (string.IsNullOrEmpty(cliente.cedula))
            {
                throw new ArgumentException("La cedula esta vacio");
            }



            CDAlmacenCliente.AgregarCliente(cliente);
        }


        public static void EliminarCliente(Cliente cliente)
        {
            CDAlmacenCliente.RemoverCliente(cliente);
        }

    }
}