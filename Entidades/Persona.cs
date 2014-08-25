using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private int id { get; set; } // reemplaza a legajo
        private String nombre { get; set; }
        private String apellido { get; set; }
        private String telefono { get; set; }
        private String direccion { get; set; }
        private String mail { get; set; }
        private DateTime fNacimineto { get; set; }
        private Tipo tipo { get; set; }
    }
}