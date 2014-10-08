using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Alumno : Persona
    {
        public Alumno(string dni, string apellido, string nombre, string nacimiento, string telefono, string direccion, string mail, string pass)
        {
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
            this.nacimineto = nacimineto;
            this.telefono = telefono;
            this.direccion = direccion;
            this.mail = mail;
            this.password = pass;
        }
        enum condiciones
        {
            inscripto,
            regular,
            aprobado
        }

        private int condicion { get; set; }
    }
}
