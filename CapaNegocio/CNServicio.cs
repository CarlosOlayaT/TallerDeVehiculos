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

        public void AgregarServicio(Servicio servicio)
        {

            if (servicio.mecanico == null)
            {
                throw new ArgumentException("El mecanico no puede ser nulo");
            }

            if (servicio.cliente == null)
            {
                throw new ArgumentException("El nombre del cliente esta vacio");
            }

            if (servicio.total <= 0)
            {
                throw new ArgumentOutOfRangeException("El precio debe ser mayor a 0");
            }

            if (string.IsNullOrEmpty(servicio.estado))
            {
                throw new ArgumentException("El estado del servicio esta vacio");
            }

            if (string.IsNullOrEmpty(servicio.diagnostico))
            {
                throw new ArgumentException("La descripcion de servicio esta vacia");
            }

            if (servicio.repuestos == null)
            {
                throw new ArgumentNullException("La lista de repuestos no puede ser null");
            }


            CDAlmacenServicio.AgregarServicio(servicio);
        }


        public void EliminarServicio(Servicio servicio)
        {
            CDAlmacenServicio.RemoverServicio(servicio);
        }

        public List<Servicio> GetAll()
        {
            return CDAlmacenServicio.AlmacenServicio;
        }

        public List<Servicio> GetListTable()
        {
            List<Servicio> servicios = CDAlmacenServicio.AlmacenServicio;
            return servicios.Select(p => new Servicio
            {
                codigo = p.codigo,
                cliente = p.cliente,
                mecanico = p.mecanico,
                estado = p.estado,
                vehiculo = p.vehiculo,
                tipo = p.tipo,
                total = p.total,
                Fecha = p.Fecha,
            }).ToList();
        }

        public List<Servicio> GetListTable(string filtro)
        {
            List<Servicio> servicios = CDAlmacenServicio.AlmacenServicio;

            DateTime fechaFiltro;
            bool esFecha = DateTime.TryParse(filtro, out fechaFiltro);

            return servicios.Where(p =>
                (p.cliente.nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase)) ||
                (p.cliente.apellido.Contains(filtro, StringComparison.OrdinalIgnoreCase)) ||
                (esFecha && p.Fecha.Date == fechaFiltro.Date)
            )
            .Select(p => new Servicio
            {
                codigo = p.codigo,
                cliente = p.cliente,
                mecanico = p.mecanico,
                Fecha = p.Fecha,
                tipo = p.tipo,
                total = p.total,
                vehiculo = p.vehiculo
            }).ToList();

        }
        public List<Servicio> GetListTableCod(string filtro)
        {
            List<Servicio> servicios = CDAlmacenServicio.AlmacenServicio;


            return servicios.Where(p =>
                (p.codigo.Contains(filtro, StringComparison.OrdinalIgnoreCase))
            )
            .Select(p => new Servicio
            {
                codigo = p.codigo,
                cliente = p.cliente,
                mecanico = p.mecanico,
                Fecha = p.Fecha,
                tipo = p.tipo,
                total = p.total,
                vehiculo = p.vehiculo
            }).ToList();

        }

        public Servicio GetServicioByCode(string codigo)
        {
            List<Servicio> servicios = CDAlmacenServicio.AlmacenServicio;

            return servicios.Where(p => p.codigo.Equals(codigo)).FirstOrDefault();
        }

        public void ChangeState(Servicio servicio)
        {
            List<Servicio> servicios = CDAlmacenServicio.AlmacenServicio;

            int indice = servicios.FindIndex(s => s.codigo == servicio.codigo);
            
            if (indice > -1)
            {
                servicios[indice].estado = servicio.estado;
            }
        }
    }
}