using System.Collections.Generic;
using Entidades;
using MongoDB.Driver;

namespace Data
{
    public class DaoEspecialidad
    {
        private MongoCollection<Especialidad> especialidades;

        public DaoEspecialidad()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            especialidades = database.GetCollection<Especialidad>("test");  
        }

        private void save(Especialidad obj)
        {
            especialidades.Save(obj);
        }

        public Especialidad find(int id) 
        {
            QueryDocument query = new QueryDocument("_id", id);
            return especialidades.FindOneAs<Especialidad>(query);
        }

        public List<Especialidad> find()
        {
            List<Especialidad> ls = new List<Especialidad>();
            foreach (Especialidad obj in especialidades.FindAllAs<Especialidad>())
            {
                ls.Add(obj);
            }
            return ls;
        }

        public void delete(Especialidad obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            especialidades.Remove(query);
        }

        public void update(Especialidad obj)
        {
            save(obj);
        }

        public void insert(Especialidad obj)
        {
            save(obj);
        }

    }
}
