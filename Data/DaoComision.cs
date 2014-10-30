using System.Collections.Generic;
using Entidades;
using MongoDB.Driver;

namespace Data
{
    public class DaoComision
    {
        private MongoCollection<Comision> comisiones;

        public DaoComision()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            comisiones = database.GetCollection<Comision>("test");  
        }

        private void save(Comision obj)
        {
            comisiones.Save(obj);
        }

        public Comision find(int id) 
        {
            QueryDocument query = new QueryDocument("_id", id);
            return comisiones.FindOneAs<Comision>(query);
        }

        public List<Comision> find()
        {
            List<Comision> ls = new List<Comision>();
            foreach (Comision obj in comisiones.FindAllAs<Comision>())
            {
                ls.Add(obj);
            }
            return ls;
        }

        public void delete(Comision obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            comisiones.Remove(query);
        }

        public void update(Comision obj)
        {
            save(obj);
        }

        public void insert(Comision obj)
        {
            if (obj.id == null)
            {
                obj.id = DaoParameter.instance.getComisionNextId();
            }
            save(obj);
        }

    }
}
