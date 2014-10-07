using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Materia
    {
        private int id { get; set; }
        private String descripcion { get; set; }
        private int hsSemanales { get; set; } // null
        private int hsTotales { get; set; } // null
        private Plan plan { get; set; }
    }
}
