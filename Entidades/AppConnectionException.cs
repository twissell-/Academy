using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public  class AppConnectionException : Exception
    {
        public AppConnectionException()
            : base("No se pudo establecer conexion con la base de datos")
        {

        }
    }
}
