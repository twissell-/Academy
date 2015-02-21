using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Data;

namespace Bussines
{
    public interface IControllerPersona
    {
        Persona find(int id);
        List<Persona> find();
        void delete(Persona obj);
        void update(Persona obj);
        void insert(Persona obj);
    }
}
