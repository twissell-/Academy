using System.Collections.Generic;
using Entidades;
using MongoDB.Driver;

namespace Data
{
    class DaoMateria
    {
        private MongoCollection<Materia> materias;

        public DaoMateria()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            materias = database.GetCollection<Materia>("test");  
        }

        private void save(Materia obj)
        {
            materias.Save(obj);
        }

        public Materia find(int id) 
        {
            QueryDocument query = new QueryDocument("_id", id);
            return materias.FindOneAs<Materia>(query);
        }

        public List<Materia> find()
        {
            List<Materia> ls = new List<Materia>();
            foreach (Materia obj in materias.FindAllAs<Materia>())
            {
                ls.Add(obj);
            }
            return ls;
        }

        public void delete(Materia obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            materias.Remove(query);
        }

        public void update(Materia obj)
        {
            save(obj);
        }

        public void insert(Materia obj)
        {
            save(obj);
        }

    }
}
