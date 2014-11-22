﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Comision
    {
        public int id { get; set; }
        public int anioCursado { get; set; }
        public Decimal HsSemanales { get; set; }
        public Decimal HsTotales { get; set;} 
        public Materia materia { get; set; }
        public List<Docente> docentes { get; set; }
        public List<Alumno> alumnos { get; set; }
        public int turno { get; set; }

        public Comision(int id, int anioCursado, Decimal hsSemanales, Decimal hsTotales, Materia materia, List<Docente> docentes, List<Alumno> alumnos, int turno)
            : this(anioCursado, hsSemanales, hsTotales, materia, docentes, turno)       
        {
            this.id = id;
        }
        public Comision(int anioCursado, Decimal hsSemanales, Decimal hsTotales, Materia materia, List<Docente> docentes, int turno)
        // Constructor para nuevas comisiones.
        {
            this.anioCursado = anioCursado;
            this.materia = materia;
            this.docentes = docentes;
            this.alumnos = new List<Alumno>();
            this.turno = turno;
            this.HsSemanales = hsSemanales;
            this.HsTotales = hsTotales;
        }
    }
}
    


