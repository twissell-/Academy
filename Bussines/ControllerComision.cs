using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Entidades;

namespace Bussines
{
    public class ControllerComision

    {
        private DaoComision dao;

        public ControllerComision()
        {
            dao = new DaoComision();
        }

        public Comision find(int id)
        {
            return dao.find(id);
        }

        public List<Comision> find()
        {
            return dao.find();
        }

        public void delete(Comision obj)
        {
            dao.delete(obj);
        }

        public void update(Comision obj)
        {
            dao.update(obj);
        }

        public void insert(Comision obj)
        {
            dao.insert(obj);
        }
    }
}