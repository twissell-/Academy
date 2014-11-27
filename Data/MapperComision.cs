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
        public int anioCursado { get; set; }
        public int materia { get; set; }
        public List<Object> docentes { get; set; }
        public List<int[]> alumnos { get; set; }
        public int turno { get; set; }
        
        public MapperComision(Comision c)
        {
            this.id = c.id;
            this.anioCursado = c.anioCursado;
            this.materia = c.materia.id;
            this.docentes = new List<Object>();
            foreach (Docente d in c.docentes)
            {
                var aux = new {id = d.id, cargo = d.cargo };
                this.docentes.Add(aux);
            }
            this.alumnos = new List<int[]>();
            foreach (Alumno a in c.alumnos)
            {
                int[] aux = new int[2];
                aux[0] = a.id;
                aux[1] = a.condicion;
                this.alumnos.Add(aux);
            }
            this.turno = c.turno;
        }
    }
}
