using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entidades;

namespace Bussines
{
    public class ControllerCargos
    {
        private List<Cargo> cargos {get; set;}

        public ControllerCargos()
        {
            this.cargos = new List<Cargo>();
            this.cargos.Add(new Cargo(0, "Titular"));
            this.cargos.Add(new Cargo(1, "Adjunto"));
            this.cargos.Add(new Cargo(2, "JTP"));
            this.cargos.Add(new Cargo(3, "Auxiliar"));
        }

        public List<Cargo> find()
        {
            return cargos;
        }

        public Cargo find(int id)
        {
            Cargo r = new Cargo(-1, ""); //Para que no rompa con que devuelve una var no asignada;
            foreach (Cargo c in cargos)
	        {
                if (c.id == id) r = c;
	        }
            return r;
        }
    }
}
