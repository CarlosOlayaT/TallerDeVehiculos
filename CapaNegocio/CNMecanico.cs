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
            if (!Regex.IsMatch(mecanico.nombre, @"^[A-Za-zÑñ\s]{3,}$ "))
            {
                throw new ArgumentException("El campo del nombre solo debe tener letras y no debe tener un minimo de 3 letras");
            }

            //validacion del apellido
            if (string.IsNullOrWhiteSpace(mecanico.apellido))
            {
                throw new ArgumentException("EL campo del apellido esta vacion");
            }
            if (!Regex.IsMatch(mecanico.apellido, @"^[A-Za-zÑñ\s]{3,}$ "))
            {
                throw new ArgumentException("El campo del apellido solo debe tener letras y no debe tener un minimo de 3 letras");
            }

            //validacion de la especialidad
            if (string.IsNullOrWhiteSpace(mecanico.Especialidad))
            {
                throw new ArgumentException("EL campo de la especialidad esta vacio");
            }
            if (!Regex.IsMatch(mecanico.Especialidad, @"^[A-Za-zÑñ\s]{3,}$ "))
            {
                throw new ArgumentException("El campo de la especialidad solo debe tener letras y no debe tener un minimo de 3 letras");
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

    }
}