using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Entidades;

namespace Bussines
{
    public class ControllerTipo
    {
        private DaoTipo dao;

        public ControllerTipo()
        {
            dao = new DaoTipo();
        }

        public Tipo find(int id)
        {
            return dao.find(id);
        }

        public List<Tipo> find()
        {
            return dao.find();
        }

        public void delete(Tipo obj)
        {
            dao.delete(obj);
        }

        public void update(Tipo obj)
        {
            dao.update(obj);
        }

        public void insert(Tipo obj)
        {
            dao.insert(obj);
        }
    }
}