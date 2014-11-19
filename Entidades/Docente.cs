using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Docente : Persona
    {

        public int cargo { get; set; }
        public bool asignado { get; set; }

        public Docente(String nombre, String apellido, String dni, String telefono, String direccion,
            String mail, String nacimiento, String password)
            : base(nombre, apellido, dni, telefono, direccion, mail, nacimiento, password)
        {

        }

        public Docente (int id, String nombre, String apellido, String dni, String telefono, String direccion, 
            String mail, String nacimiento, String password)
            : this(nombre,apellido,dni,telefono,direccion,mail,nacimiento,password)
        {
            this.id = id;
        }

        public Docente(int id, String nombre, String apellido, String dni, String telefono, String direccion,
            String mail, String nacimiento, String password, int cargo)
            : this(id, nombre, apellido, dni, telefono, direccion, mail, nacimiento, password)
        {
            this.cargo = cargo;
        }
       
    }
     
}
