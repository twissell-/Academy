using System.Collections.Generic;
using Entidades;
using MongoDB.Driver;

namespace Data
{
    class DaoPlan
    {
        private MongoCollection<Plan> planes;

        public DaoPlan()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            planes = database.GetCollection<Plan>("test");  
        }

        private void save(Plan obj)
        {
            planes.Save(obj);
        }

        public Plan find(int id) 
        {
            QueryDocument query = new QueryDocument("_id", id);
            return planes.FindOneAs<Plan>(query);
        }

        public List<Plan> find()
        {
            List<Plan> ls = new List<Plan>();
            foreach (Plan obj in planes.FindAllAs<Plan>())
            {
                ls.Add(obj);
            }
            return ls;
        }

        public void delete(Plan obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            planes.Remove(query);
        }

        public void update(Plan obj)
        {
            save(obj);
        }

        public void insert(Plan obj)
        {
            save(obj);
        }

    }
}
