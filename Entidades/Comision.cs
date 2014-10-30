using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Comision
    {
        public int id { get; set; }
       // public String turno { get; set; }
        public int anioCursado { get; set; }
        public  float HsSemanales { get; set; }
        public  float HsTotales { get; set;} 
        public Materia materia { get; set; }
        public Docente[] docentes { get; set; }
        public Alumno[] alumnos { get; set; }
        private int turno { get; set; }
        enum cTurno
        {
            Mañana,
            Tarde,
            Noche
        }

        public Comision(int id, int anioCursado,float hsSemanales,float hsTotales, Materia materia, Docente[] docentes, Alumno[] alumnos, int turnos)
        {
            this.id = id;
            this.anioCursado = anioCursado;
            this.materia = materia;
            this.docentes = docentes;
            this.alumnos = alumnos;
            this.turno = turnos;
            this.HsSemanales=hsSemanales;
            this.HsTotales= hsTotales;
        }
    }
}
    


