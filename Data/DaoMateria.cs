using System.Collections.Generic;
using Entidades;
using Util;
using MongoDB.Driver;

namespace Data
{
    public class DaoMateria
    {
        private MongoCollection<MapperMateria> materias;

        public DaoMateria()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            materias = database.GetCollection<MapperMateria>("materias");  
        }

        private void save(Materia obj)
        {
            materias.Save(new MapperMateria(obj));
        }

        private Materia mapper(MapperMateria m)
        {
            DaoPlan dp = new DaoPlan();
            return new Materia(m.id, m.descripcion, m.hsSemanales, m.hsTotales, dp.find(m.plan));
        }

        public Materia find(int id) 
        {
            QueryDocument query = new QueryDocument("_id", id);
            return mapper(materias.FindOneAs<MapperMateria>(query));
        }

        public List<Materia> find()
        {
            List<Materia> ls = new List<Materia>();
            foreach (MapperMateria obj in materias.FindAllAs<MapperMateria>())
            {
                ls.Add(mapper(obj));
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
            if (obj.id == 0)
            {
                obj.id = DaoParameter.instance.getMateriaNextId();
            }
            save(obj);
        }

    }
}
