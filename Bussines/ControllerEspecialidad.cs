using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Entidades;

namespace Bussines
{
    public class ControllerEspecialidad
    {
        private DaoEspecialidad dao;

        public ControllerEspecialidad()
        {
            dao = new DaoEspecialidad();
        }

        public Especialidad find(int id)
        {
            return dao.find(id);
        }

        public List<Especialidad> find()
        {
            return dao.find();
        }

        public void delete(Especialidad obj)
        {
            dao.delete(obj);
        }

        public void update(Especialidad obj)
        {
            dao.update(obj);
        }

        public void insert(Especialidad obj)
        {
            dao.insert(obj);
        }
    }
}