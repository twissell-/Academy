using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class MapperEstado
    {
        public int id { get; set; }
        public int estado { get; set; }

        public MapperEstado(int id, int estado)
        {
            this.id = id;
            this.estado = estado;
        }
    }
}
