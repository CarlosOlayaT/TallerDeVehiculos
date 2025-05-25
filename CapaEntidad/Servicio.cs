using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Servicio
    {
        public string codigo {get; set; }
        public Mecanico mecanico { get; set; }
        public Cliente cliente { get; set; }
        public Vehiculo vehiculo { get; set; }
        public float total { get; set; }
        public string estado { get; set; }
        public string diagnostico { get; set; }
        public string trabajosRealizados { get; set; }
        public float subtbase { get; set; }
        public List<Repuesto> repuestos { get; set; }
        public float subtrep {  get; set; }
        public List<string> ServAdicionales { get; set; }
        public float SubtAdd {  get; set; }

        public string tipo { get; set; }
        public DateTime Fecha { get; set; }= DateTime.Now;

        public Servicio(Mecanico mecanico, Cliente cliente, List<Repuesto> repuestos, Vehiculo vehiculo,string tipo, float precio, string estado, string descripcion)
        {
            this.mecanico = mecanico;
            this.cliente = cliente;
            this.vehiculo = vehiculo;
            this.total = precio;
            this.tipo = tipo;
            this.estado = estado;
            this.diagnostico = descripcion;
            this.repuestos = repuestos;
        }
        public Servicio()
        {
        }
        public override string ToString()
        {
            return $"Servicio [mecanico={mecanico.ToString()}, cliente={cliente.ToString()}, precio={total}, tipo={tipo}, estado={estado}, descripcion={diagnostico}]";
        }

    }
}