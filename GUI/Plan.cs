using System;
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
        public List<Materia> materias { get; set; }

        public Plan(int id, String descripcion, Especialidad especialidad, List<Materia> materias)   
        {
            this.id = id;
            this.descripcion = descripcion;
            this.especialidad = especialidad;
            this.materias = materias;
        }

        public Plan(int id, string descripcion, Especialidad especialidad)
            : this(id, descripcion, especialidad, new List<Materia>())
        {

        }

        public Plan(string descripcion, Especialidad especialidad)
            : this(0, descripcion, especialidad) 
        {

        }

        public override string ToString()
        {
            return this.descripcion;
        }
    }
}
