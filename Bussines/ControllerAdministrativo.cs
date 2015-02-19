using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Entidades;

namespace Bussines
{
    public class ControllerAdministrativo : IControllerPersona
    {
        private DaoAdministrativo dao;

        public ControllerAdministrativo()
        {
            try
            {
                dao = new DaoAdministrativo();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Persona find(int id)
        {
            return dao.find(id);
        }

        public List<Persona> find()
        {
            return dao.find();
        }

        public void delete(Persona obj)
        {
            dao.delete(obj);
        }

        public void update(Persona obj)
        {
            dao.update(obj);
        }

        public void insert(Persona obj)
        {
            dao.insert(obj);
        }

        
        
    }
}
