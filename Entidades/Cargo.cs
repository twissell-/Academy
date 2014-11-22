using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cargo
    {
        public int id { get; set; }
        public String descripcion { get; set; }

        public Cargo(int id, String descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public override String ToString()
        {
            return this.descripcion;
        }
    }
}
