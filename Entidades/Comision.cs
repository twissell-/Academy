using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Comision
    {
        public int id { get; set; }
        public int anioCursado { get; set; }
        public  float HsSemanales { get; set; }
        public  float HsTotales { get; set;} 
        public Materia materia { get; set; }
        public Docente[] docentes { get; set; }
        public Alumno[] alumnos { get; set; }
        public int turno { get; set; }

        public Comision(int id, int anioCursado,float hsSemanales,float hsTotales, Materia materia, Docente[] docentes, Alumno[] alumnos, int turno)
            : this(anioCursado, hsSemanales, hsTotales, materia, docentes, alumnos, turno)       
        {
            this.id = id;
        }
        public Comision(int anioCursado, float hsSemanales, float hsTotales, Materia materia, Docente[] docentes, Alumno[] alumnos, int turno)
        // Constructor para nuevas comisiones.
        {
            this.anioCursado = anioCursado;
            this.materia = materia;
            this.docentes = docentes;
            this.alumnos = alumnos;
            this.turno = turno;
            this.HsSemanales = hsSemanales;
            this.HsTotales = hsTotales;
        }
    }
}
    


