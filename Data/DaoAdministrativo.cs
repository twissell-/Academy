using System.Collections.Generic;
using Entidades;
using MongoDB.Driver;

namespace Data
{
    public class DaoAdministrativo
    {
        private MongoCollection<Administrativo> administrativos;

        public DaoAdministrativo()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            administrativos = database.GetCollection<Administrativo>("administrativos");  
        }

        private void save(Administrativo obj)
        {
            administrativos.Save(obj);
        }

        public Administrativo find(int id) 
        {
            QueryDocument query = new QueryDocument("_id", id);
            return administrativos.FindOneAs<Administrativo>(query);
        }

        public List<Administrativo> find()
        {
            List<Administrativo> ls = new List<Administrativo>();
            foreach (Administrativo obj in administrativos.FindAllAs<Administrativo>())
            {
                ls.Add(obj);
            }
            return ls;
        }

        public void delete(Administrativo obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            administrativos.Remove(query);
        }

        public void update(Administrativo obj)
        {
            save(obj);
        }

        public void insert(Administrativo obj)
        {
            if (obj.id == 0)
            {
                obj.id = DaoParameter.instance.getAdministrativoNextId();
            }
            save(obj);
        }

    }
}
