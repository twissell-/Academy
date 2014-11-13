using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util;

namespace Entidades
{
    public abstract class Persona
    {
        public int id { get; set; } // reemplaza a legajo
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String dni { get; set; }
        public String telefono { get; set; }
        public String direccion { get; set; }
        public String mail { get; set; }
        public String nacimiento { get; set; }  // <--- TODO: Guardar como DateTime
        public String password { get; set; }

        public Persona(String nombre, String apellido, String dni, String telefono, String direccion,
           String mail, String nacimiento, String password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.mail = mail;
            this.nacimiento = nacimiento;
            this.password = Hasher.toMD5(password);
        }        
    }
}