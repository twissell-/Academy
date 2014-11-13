using System.Collections.Generic;
using Entidades;
using MongoDB.Driver;

namespace Data
{
    public class DaoTipo
    {
        private MongoCollection<Tipo> tipos;

        public DaoTipo()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            tipos = database.GetCollection<Tipo>("tipos");  
        }

        private void save(Tipo obj)
        {
            tipos.Save(obj);
        }

        public Tipo find(int id) 
        {
            QueryDocument query = new QueryDocument("_id", id);
            return tipos.FindOneAs<Tipo>(query);
        }

        public List<Tipo> find()
        {
            List<Tipo> ls = new List<Tipo>();
            foreach (Tipo obj in tipos.FindAllAs<Tipo>())
            {
                ls.Add(obj);
            }
            return ls;
        }

        public void delete(Tipo obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            tipos.Remove(query);
        }

        public void update(Tipo obj)
        {
            save(obj);
        }

        public void insert(Tipo obj)
        {
            save(obj);
        }
    }
}
