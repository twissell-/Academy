using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entidades;

namespace Util
{
    public class MapperPlan
    {
        public int id { get; set; }
        public String descripcion { get; set; }
        public int especialidad { get; set; }
        public int[] materias { get; set; }


        public MapperPlan(Plan p)
        {
            this.id = p.id;
            this.descripcion = p.descripcion;
            this.especialidad = p.especialidad.id;
            this.materias =  new int[p.materias.Length];
            for (int i = 0; i < p.materias.Length; i++)
            {
                this.materias[i] = p.materias[i].id;
            }
        }
    }
}
