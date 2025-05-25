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
    public class CNMecanico
    {

        public void AgregarMecanico(Mecanico mecanico)
        {
            //validacion del nombre
            if (string.IsNullOrWhiteSpace(mecanico.nombre))
            {
                throw new ArgumentException("EL campo del nombre esta vacio");
            }
            if (!Regex.IsMatch(mecanico.nombre, @"^[A-Za-zÑñ\s]"))
            {
                throw new ArgumentException("El campo del nombre solo debe tener letras");
            }
            if (mecanico.nombre.Length < 3)
            {
                throw new ArgumentException("El nombre debe tener un minimo de 3 letras");
            }

            //validacion del apellido
            if (string.IsNullOrWhiteSpace(mecanico.apellido))
            {
                throw new ArgumentException("EL campo del apellido esta vacio");
            }
            if (!Regex.IsMatch(mecanico.apellido, @"^[A-Za-zÑñ\s]"))
            {
                throw new ArgumentException("El campo del apellido solo debe tener letras");
            }
            if (mecanico.apellido.Length < 3)
            {
                throw new ArgumentException("El apellido debe tener un minimo de 3 letras");
            }


            //validacion de la especialidad
            if (string.IsNullOrWhiteSpace(mecanico.Especialidad))
            {
                throw new ArgumentException("EL campo de la especialidad esta vacio");
            }
            if (!Regex.IsMatch(mecanico.Especialidad, @"^[A-Za-zÑñ\s]"))
            {
                throw new ArgumentException("El campo de la especialidad solo debe tener letras");
            }
            if (mecanico.Especialidad.Length < 3)
            {
                throw new ArgumentException("La especialidad debe tener un minimo de 3 letras");
            }

            if (mecanico.cedula.Length != 10)
            {
                throw new ArgumentException("La cedula debe de tener 10 digitos");
            }

            if (mecanico.telefono.Length != 10)
            {
                throw new ArgumentException("El telefono debe de tener 10 digitos");
            }

            //validacion de los años de experiencia
            if (mecanico.AniosExperiencia < 0 || mecanico.AniosExperiencia > 60)
            {
                throw new ArgumentException("El valor de los años de experiencia deben estar en un rango entre 0 y 60");
            }






            CDAlmacenMecanico.AgregarMecanico(mecanico);
        }


        public void EliminarMecanico(Mecanico mecanico)
        {
            CDAlmacenMecanico.RemoverMecanico(mecanico);
        }

        public List<Mecanico> GetAlls()
        {

            return CDAlmacenMecanico.AlmacenMecanico;
        }
        public List<Mecanico> GetMecanicoList()
        {
            List<Mecanico> mecanicos = CDAlmacenMecanico.AlmacenMecanico; 
            return mecanicos.Select(p => new Mecanico
            {
                cedula = p.cedula,
                nombre = $"{p.nombre} {p.apellido}",
                AniosExperiencia = p.AniosExperiencia,
                Especialidad = p.Especialidad,
                telefono = p.telefono,
                Estado = p.Estado
            }).ToList();
        }

        public List<Mecanico> GetListTable(string filtro)
        {
            List<Mecanico> mecanicos = CDAlmacenMecanico.AlmacenMecanico; 
            return mecanicos.Where(p => p.nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
            p.cedula.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                .Select(p => new Mecanico
                {
                    cedula = p.cedula,
                    nombre = $"{p.nombre} {p.apellido}",
                    AniosExperiencia = p.AniosExperiencia,
                    Especialidad = p.Especialidad,
                    telefono = p.telefono,
                    Estado = p.Estado
                }).ToList();
        }
        public void ChangeState(Mecanico mecanico, bool estado)
        {
            List<Mecanico> mecanicos = CDAlmacenMecanico.AlmacenMecanico;

            int indice = mecanicos.FindIndex(s => s.cedula == mecanico.cedula);

            if (indice > -1)
            {
                mecanicos[indice].Estado = estado;
            }
        }

    }
}