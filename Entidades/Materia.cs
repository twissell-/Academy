using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Materia
    {
        public int id { get; set; }
        public String descripcion { get; set; }
        public int hsSemanales { get; set; } // null
        public int hsTotales { get; set; } // null
        public Plan plan { get; set; }

        public Materia(int id, String descripcion, int hsSemanales, int hsTotales, Plan plan) 
        {
            this.id = id;
            this.descripcion = descripcion;
            this.hsSemanales = hsSemanales;
            this.hsTotales = hsTotales;
            this.plan = plan;
        }
    }
}
