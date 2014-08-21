using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Data;
using Entidades;



namespace Bussines
{
    class Program
    {
        static void Main(string[] args)
        {
            DaoTipo dao = new DaoTipo();
            Tipo tipo = new Tipo {id = 0, descripcion = "Administrativo" };
            dao.addOne(tipo);

        }
    }
}
