using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDAlmacenCliente
    {
        public static List<Cliente> AlmacenClientes = new List<Cliente>();


        public static void AgregarCliente(Cliente cliente)
        {
            AlmacenClientes.Add(cliente);

        }


        public static void RemoverCliente(Cliente cliente)
        {
            AlmacenClientes.Remove(cliente);
        }

    }

}