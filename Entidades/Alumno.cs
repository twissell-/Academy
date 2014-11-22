using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Alumno : Persona
    {
        public int condicion { get; set; }

        public Alumno(String dni, String apellido, String nombre, String nacimiento, String telefono, 
            String direccion, String mail, String password)
            : base(nombre, apellido, dni, telefono, direccion, mail, nacimiento, password)
        {

        }

        public Alumno(int id, String dni, String apellido, String nombre, String nacimiento, String telefono,
            String direccion, String mail, String password)
            : this(nombre, apellido, dni, telefono, direccion, mail, nacimiento, password)
        {
            this.id = id;
        }

        public Alumno(int id, String dni, String apellido, String nombre, String nacimiento, String telefono,
            String direccion, String mail, String password, int condicion)
            : this(id, nombre, apellido, dni, telefono, direccion, mail, nacimiento, password)
        {
            this.condicion = condicion;
        }

        enum condiciones
        {
            inscripto,
            regular,
            aprobado
        }

    }
}
