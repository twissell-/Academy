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
    }
}
