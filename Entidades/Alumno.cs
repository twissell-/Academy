using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Alumno
    {
        enum condiciones
        {
            inscripto,
            regular,
            aprobado
        }

        public int condicion { get; set; }
    }
}
