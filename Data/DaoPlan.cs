using System.Collections.Generic;
using Entidades;
using Util;
using MongoDB.Driver;

namespace Data
{
    public class DaoPlan
    {
        private MongoCollection<MapperPlan> planes;

        public DaoPlan()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            planes = database.GetCollection<MapperPlan>("planes");  
        }

        private void save(Plan obj)
        {
            planes.Save(new MapperPlan(obj));
        }

        private Plan mapper(MapperPlan mapper)
        {
            DaoMateria dm = new DaoMateria();
            DaoEspecialidad de = new DaoEspecialidad();
            List<Materia> materias = new List<Materia>(mapper.materias.Length);
            for (int i = 0; i < mapper.materias.Length; i++)
            {
                materias.Add(dm.find(mapper.materias[i]));
            }

            return new Plan(mapper.id, mapper.descripcion, de.find(mapper.especialidad), materias);
        }
        public Plan find(int id)
        {
            QueryDocument query = new QueryDocument("_id", id);
            return mapper(planes.FindOneAs<MapperPlan>(query));
            
        }     

        public List<Plan> find()
        {
            List<Plan> ls = new List<Plan>();
            foreach (MapperPlan obj in planes.FindAllAs<MapperPlan>())
            {
                ls.Add(mapper(obj));
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
            if (obj.id == 0)
            {
                obj.id = DaoParameter.instance.getPlanNextId();
            }
            save(obj);
        }

    }
}
