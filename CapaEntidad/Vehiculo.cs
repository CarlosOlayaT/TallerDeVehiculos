using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Vehiculo
    {
        public string placa { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public int anio { get; set; }

        public Servicio Servicio
        {
            get => default;
            set
            {
            }
        }

        public DateTime Fecha = DateTime.Now;

        public Vehiculo()
        {

        }
        public Vehiculo(string placa, string modelo, string marca, int anio, DateTime? date)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.marca = marca;
            this.anio = anio;
        }
        public override string ToString()
        {
            return $"{placa}";
        }
    }
}
