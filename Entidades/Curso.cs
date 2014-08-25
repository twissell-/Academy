using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Curso
    {
        private int id { get; set; }
        private Comision comision { get; set; }
        private Materia  materia { get; set; }
        private Docente[] docentes { get; set; }
        private Alumno[] alumnos { get; set; }

    }
}
