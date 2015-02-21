using System.Collections.Generic;
using Entidades;
using MongoDB.Driver;

namespace Data
{
    public class DaoAdministrativo : IDaoPersona

    {
        private MongoCollection<Administrativo> administrativos;

        public DaoAdministrativo()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            administrativos = database.GetCollection<Administrativo>("administrativos");  
        }

        private void save(Persona obj)
        {
            administrativos.Save((Administrativo)obj);
        }

        public Persona find(int id) 
        {
            try
            {
                QueryDocument query = new QueryDocument("_id", id);
                return (Persona)administrativos.FindOneAs<Administrativo>(query);
            }
            catch (MongoConnectionException)
            {
                throw new AppConnectionException();
            }
        }

        public List<Persona> find()
        {
            List<Persona> ls = new List<Persona>();
            foreach (Administrativo obj in administrativos.FindAllAs<Administrativo>())
            {
                ls.Add((Persona)obj);
            }
            return ls;
        }

        public void delete(Persona obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            administrativos.Remove(query);
        }

        public void update(Persona obj)
        {
            save(obj);
        }

        public void insert(Persona obj)
        {
            if (obj.id == 0)
            {
                obj.id = DaoParameter.instance.getAdministrativoNextId();
            }
            save(obj);
        }

    }
}
