using System.Collections.Generic;
using Entidades;
using MongoDB.Driver;

namespace Data
{
    public class DaoAlumno
    {
        private MongoCollection<Alumno> alumnos;

        public DaoAlumno()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            alumnos = database.GetCollection<Alumno>("alumnos");  
        }

        private void save(Alumno obj)
        {
            alumnos.Save(obj);
        }

        public Alumno find(int id) 
        {
            QueryDocument query = new QueryDocument("_id", id);
            return alumnos.FindOneAs<Alumno>(query);
        }

        public List<Alumno> find()
        {
            List<Alumno> ls = new List<Alumno>();
            foreach (Alumno obj in alumnos.FindAllAs<Alumno>())
            {
                ls.Add(obj);
            }
            return ls;
        }

        public void delete(Alumno obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            alumnos.Remove(query);
        }

        public void update(Alumno obj)
        {
            save(obj);
        }

        public void insert(Alumno obj)
        {
            if (obj.id == 0)
            {
                obj.id = DaoParameter.instance.getAlumnoNextId();
            }
            save(obj);
        }

    }
}
