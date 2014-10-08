﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        public int id { get; set; } // reemplaza a legajo
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String dni { get; set; }
        public String telefono { get; set; }
        public String direccion { get; set; }
        public String mail { get; set; }
        public String nacimineto { get; set; }  // <--- Guardar como DateTime
        public String password { get; set; }
        public Tipo tipo { get; set; } // <-- ojo! creo que esta al pedo o mal puesto
    }
}