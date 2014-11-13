using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Entidades;

namespace Bussines
{
    public class ControllerAdministrativo
    {
        private DaoAdministrativo dao;

        public ControllerAdministrativo()
        {
            dao = new DaoAdministrativo();
        }

        public Administrativo find(int id)
        {
            return dao.find(id);
        }

        public List<Administrativo> find()
        {
            return dao.find();
        }

        public void delete(Administrativo obj)
        {
            dao.delete(obj);
        }

        public void update(Administrativo obj)
        {
            dao.update(obj);
        }

        public void insert(Administrativo obj)
        {
            dao.insert(obj);
        }
    }
}
