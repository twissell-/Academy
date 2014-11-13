﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Plan
    {
        public int id { get; set; }
        public String descripcion { get; set; }
        public Especialidad especialidad { get; set; }
        public Materia[] materias { get; set; }


        public Plan(int id, String descripcion, Especialidad especialidad)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.especialidad = especialidad;
           
        }

        public Plan(int id, String descripcion, Especialidad especialidad, Materia[] materias)   
            : this(id,descripcion,especialidad)
        {
            this.materias = materias;
        }

        public override string ToString()
        {
            return this.descripcion;
        }
    }
}
