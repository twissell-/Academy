using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Bussines
{
    public interface InterfaceControllers
    {
        void delete(Persona p);
        void update(Persona p);
        void insert(Persona p);
        List<Persona> find();
        Persona find(int id);
    }
}
