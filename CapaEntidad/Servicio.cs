using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Servicio
    {
        public Mecanico mecanico { get; set; }
        public Cliente cliente  { get; set; }
        public decimal precio { get; set; }
        public string estado { get; set; }
        public string descripcion { get; set; }
        public List<Repuesto> repuestos { get; set; }
        public DateTime FechaRegistro = DateTime.Now;

        public Servicio(Mecanico mecanico, Cliente cliente,List<Repuesto> repuestos, decimal precio, string estado, string descripcion)
        {
            this.mecanico = mecanico;
            this.cliente = cliente;
            this.precio = precio;
            this.estado = estado;
            this.descripcion = descripcion;
            this.repuestos = repuestos;
        }

        public override string ToString()
        {
            return $"Servicio [mecanico={mecanico.ToString()}, cliente={cliente.ToString()}, precio={precio}, estado={estado}, descripcion={descripcion}]";
        }

    }
}