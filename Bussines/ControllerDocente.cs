using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Entidades;

namespace Bussines
{
    public class ControllerDocente
    {
        private DaoDocente dao;

        public ControllerDocente()
        {
            dao = new DaoDocente();
        }

        public Docente find(int id)
        {
            return dao.find(id);
        }

        public List<Docente> find()
        {
            return dao.find();
        }

        public void delete(Docente obj)
        {
            dao.delete(obj);
        }

        public void update(Docente obj)
        {
            dao.update(obj);
        }

        public void insert(Docente obj)
        {
            dao.insert(obj);
        }
    }
}