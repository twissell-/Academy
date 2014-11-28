using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Data;

namespace Util
{
    public class MapperComision
    {
        public int id { get; set; }
        public int anioCursado { get; set; }
        public int materia { get; set; }
        public List<MapperEstado> docentes { get; set; }
        public List<MapperEstado> alumnos { get; set; }
        public int turno { get; set; }
        
        public MapperComision(Comision c)
        {
            this.id = c.id;
            this.anioCursado = c.anioCursado;
            this.materia = c.materia.id;
            this.docentes = new List<MapperEstado>();
            foreach (Docente d in c.docentes)
            {
                this.docentes.Add(new MapperEstado(d.id, d.cargo));
            }
            this.alumnos = new List<MapperEstado>();
            foreach (Alumno a in c.alumnos)
            {
                this.alumnos.Add(new MapperEstado(a.id, a.condicion));
            }
            this.turno = c.turno;
        }
    }
}
