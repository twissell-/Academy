using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Docente : Persona
    {

        enum eCargo
        {
            titular,
            adjunto,
            jtp,
            auxPrimera,
        }
        private int cargo { get; set; }

        public Docente (int id, String nombre, String apellido, String dni, String telefono, String direccion, 
        String mail, String nacimiento, String password, Tipo tipo, int cargo): base (id,nombre,apellido,dni,telefono,direccion,mail,nacimiento,password/*,tipo*/)
        {
            
            this.cargo = cargo;
        }

       
    }
     
}
