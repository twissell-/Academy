using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Curso
    {
        public int id { get; set; }
        public Comision comision { get; set; }
        public Materia  materia { get; set; }
        public Docente[] docentes { get; set; }
        public Alumno[] alumnos { get; set; }

    }
}
