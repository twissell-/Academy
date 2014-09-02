using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Docente : Persona
    {
        enum cargo
        {
            titular,
            adjunto,
            jtp,
            auxPrimera,
        }
        private int cargo { get; set; }
    }
}
