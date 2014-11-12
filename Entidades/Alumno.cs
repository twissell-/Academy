using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Alumno : Persona
    {
       /* public Alumno(string dni, string apellido, string nombre, string nacimiento, string telefono, string direccion, string mail, string pass)
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
        * 
        * Comment no! Delete it, or delete not. There is no comment
        
        
        */
        public Alumno(int id, String dni, String apellido, String nombre, String nacimiento, String telefono, String direccion,
        String mail, String password/*, Tipo tipo, int condicion*/): base(id, nombre, apellido, dni, telefono, direccion, mail, nacimiento, password/*, tipo*/)
        {
            this.condicion = condicion;
        }
        enum condiciones
        {
            inscripto,
            regular,
            aprobado
        }
        public Alumno() { }

        private int condicion { get; set; }
    }
}
