using System.Collections.Generic;
using Entidades;
using MongoDB.Driver;

namespace Data
{
    public class DaoDocente
    {
        private MongoCollection<Docente> docentes;

        public DaoDocente()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            docentes = database.GetCollection<Docente>("docentes");  
        }

        private void save(Docente obj)
        {
            docentes.Save(obj);
        }

        public Docente find(int id) 
        {
            QueryDocument query = new QueryDocument("_id", id);
            return docentes.FindOneAs<Docente>(query);
        }

        public List<Docente> find()
        {
            List<Docente> ls = new List<Docente>();
            foreach (Docente obj in docentes.FindAllAs<Docente>())
            {
                ls.Add(obj);
            }
            return ls;
        }

        public void delete(Docente obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            docentes.Remove(query);
        }

        public void update(Docente obj)
        {
            save(obj);
        }

        public void insert(Docente obj)
        {
            if (obj.id == 0)
            {
                obj.id = DaoParameter.instance.getDocenteNextId();
            }
            save(obj);
        }

    }
}
