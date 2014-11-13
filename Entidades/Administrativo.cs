using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Administrativo : Persona
    {

        public Administrativo(String nombre, String apellido, String dni, String telefono, String direccion,
           String mail, String nacimiento, String password)
            : base(nombre, apellido, dni, telefono, direccion, mail, nacimiento, password)
        {

        }
        public Administrativo(int id, String nombre, String apellido, String dni, String telefono, String direccion,
           String mail, String nacimiento, String password)
            : this(nombre, apellido, dni, telefono, direccion, mail, nacimiento, password)
        {
            this.id = id;
        }
    }
}
