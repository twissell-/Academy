using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Entidades;

namespace Bussines
{
    public class ControllerMateria
    {
        private DaoMateria dao;

        public ControllerMateria()
        {
            dao = new DaoMateria();
        }

        public Materia find(int id)
        {
            return dao.find(id);
        }

        public List<Materia> find()
        {
            return dao.find();
        }

        public void delete(Materia obj)
        {
            dao.delete(obj);
        }

        public void update(Materia obj)
        {
            dao.update(obj);
        }

        public void insert(Materia obj)
        {
            dao.insert(obj);
        }
    }
}
