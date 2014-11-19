using System.Collections.Generic;
using Entidades;
using MongoDB.Driver;

namespace Data
{
    public class DaoDocente : IDaoPersona
    {
        private MongoCollection<Docente> docentes;

        public DaoDocente()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            docentes = database.GetCollection<Docente>("docentes");  
        }

        private void save(Persona obj)
        {
            docentes.Save((Docente)obj);
        }

        public Persona find(int id) 
        {
            QueryDocument query = new QueryDocument("_id", id);
            return (Persona)docentes.FindOneAs<Docente>(query);
        }

        public List<Persona> find()
        {
            List<Persona> ls = new List<Persona>();
            foreach (Docente obj in docentes.FindAllAs<Docente>())
            {
                ls.Add((Persona)obj);
            }
            return ls;
        }

        public void delete(Persona obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            docentes.Remove(query);
        }

        public void update(Persona obj)
        {
            save(obj);
        }

        public void insert(Persona obj)
        {
            if (obj.id == 0)
            {
                obj.id = DaoParameter.instance.getDocenteNextId();
            }
            save(obj);
        }

    }
}
