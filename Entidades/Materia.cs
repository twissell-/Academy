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
        public decimal hsSemanales { get; set; } // null
        public decimal hsTotales { get; set; } // null
        public Plan plan { get; set; }

        public Materia(int id, String descripcion, decimal hsSemanales, decimal hsTotales, Plan plan) 
        {
            this.id = id;
            this.descripcion = descripcion;
            this.hsSemanales = hsSemanales;
            this.hsTotales = hsTotales;
            this.plan = plan;
        }

        public Materia(String descripcion, decimal hsSemanales, decimal hsTotales, Plan plan)
            : this(0, descripcion, hsSemanales, hsTotales, plan)
        {

        }

        public override string ToString()
        {
            return this.descripcion;
        }
    }
}
