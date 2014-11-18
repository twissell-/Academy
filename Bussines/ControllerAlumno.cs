using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Entidades;

namespace Bussines
{
    public class ControllerAlumno:InterfaceControllers
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

        void InterfaceControllers.delete(Persona p)
        {
            this.delete(((Alumno)p));
        }

        void InterfaceControllers.update(Persona p)
        {
            this.update(((Alumno)p));
        }

        void InterfaceControllers.insert(Persona p)
        {
            this.insert(((Alumno)p));
        }

        List<Persona> InterfaceControllers.find()
        {
            return new List<Persona>();
        }

        Persona InterfaceControllers.find(int id)
        {
            return this.find(id);
        }
    }
}
