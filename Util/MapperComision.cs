using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Util
{
    public class MapperComision
    {
        public int id { get; set; }
        public String turno { get; set; }
        public int anioCursado { get; set; }
        public int materia { get; set; }
        public int[] docentes { get; set; }
        public int[] alumnos { get; set; }

        private int turno { get; set; }

        public MapperComision(Comision c)
        {
            this.id = c.id;
            this.anioCursado = c.anioCursado;
            this.materia = c.materia.id;
            this.docentes = new int[c.docentes.Length];
            for (int i = 0; i < c.docentes.Length; i++)
            {
                this.docentes[i] = c.docentes[i].id;
            }
            this.alumnos = new int[c.alumnos.Length];
            for (int i = 0; i < c.alumnos.Length; i++)
            {
                this.alumnos[i] = c.alumnos[i].id;
            }
            // this.turno = c.turno;
        }
    }
}
