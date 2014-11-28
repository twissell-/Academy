using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Util
{
    public class MapperMateria
    {
        public int id { get; set; }
        public String descripcion { get; set; }
        public decimal hsSemanales { get; set; } 
        public decimal hsTotales { get; set; } 
        public int plan { get; set; }

        public MapperMateria(Materia m) 
        {
            this.id = m.id;
            this.descripcion = m.descripcion;
            this.hsSemanales = m.hsSemanales;
            this.hsTotales = m.hsTotales;
            this.plan = m.plan.id;
        }
    }
}
