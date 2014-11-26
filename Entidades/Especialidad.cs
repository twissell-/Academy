using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Especialidad
    {
        public int id { get; set; }
        public String descripcion { get; set; }


        public Especialidad(int id, String descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }
        public override string ToString()
        {
            return this.descripcion;
        }
    }
}
