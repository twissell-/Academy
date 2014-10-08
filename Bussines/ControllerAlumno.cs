using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Entidades;

namespace Bussines
{
    public class ControllerAlumno
    {
        private DaoAlumno dao;

        public ControllerAlumno()
        {
            dao = new DaoAlumno();
        }

        public Alumno find(int id)
        {
            return dao.find(id);
        }

        public List<Alumno> find()
        {
            return dao.find();
        }

        public void delete(Alumno obj)
        {
            dao.delete(obj);
        }

        public void update(Alumno obj)
        {
            dao.update(obj);
        }

        public void insert(Alumno obj)
        {
            dao.insert(obj);
        }
    }
}
