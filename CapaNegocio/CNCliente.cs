using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNCliente
    {

        public void AgregarCliente(Cliente cliente)
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
            if (cliente.cedula.Length !=10)
            {
                throw new ArgumentException("La cedula debe tener 10 digitos");
            }
            if (cliente.telefono.Length != 10)
            {
                throw new ArgumentException("El numero de telefono debe tener 10 digitos");
            }
            if (string.IsNullOrEmpty(cliente.email))
            {
                throw new ArgumentException("El email esta vacio");
            }

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            Regex regex = new Regex(patron);
            if (!regex.IsMatch(cliente.email))
            {
                throw new ArgumentException("El correo del cliente no es valido");
            }



            CDAlmacenCliente.AgregarCliente(cliente);
        }


        public void EliminarCliente(Cliente cliente)
        {
            CDAlmacenCliente.RemoverCliente(cliente);
        }


        public List<Cliente> GetClientes()
        {
            return CDAlmacenCliente.AlmacenClientes;
        }

    }
}