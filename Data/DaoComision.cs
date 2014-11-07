using System.Collections.Generic;
using Entidades;
using Util;
using MongoDB.Driver;

namespace Data
{
    public class DaoComision
    {
        private MongoCollection<MapperComision> comisiones;

        public DaoComision()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            comisiones = database.GetCollection<MapperComision>("test");  
        }

        private void save(Comision obj)
        {
            comisiones.Save(new MapperComision(obj));
        }

        private Comision mapper(MapperComision mapper)
        {
            DaoAlumno da = new DaoAlumno();
            DaoDocente dd = new DaoDocente();
            DaoMateria dm = new DaoMateria();

            Alumno[] alumnos = new Alumno[mapper.alumnos.Length];
            //  recupero los objetos Alumno
            for (int i = 0; i < mapper.alumnos.Length; i++)
            {
                alumnos[i] = da.find(mapper.alumnos[i]);
            }
            //  Recupero los objetos Docente
            Docente[] docentes = new Docente[mapper.docentes.Length];
            for (int i = 0; i < mapper.docentes.Length; i++)
            {
                docentes[i] = dd.find(mapper.docentes[i]);
            }

            return new Comision(mapper.id, mapper.anioCursado, dm.find(mapper.materia), docentes, alumnos, mapper.turno);
        }

        public Comision find(int id) 
        {
            QueryDocument query = new QueryDocument("_id", id);
            return mapper(comisiones.FindOneAs<MapperComision>(query));
        }

        public List<Comision> find()
        {
            List<Comision> ls = new List<Comision>();
            foreach (MapperComision obj in comisiones.FindAllAs<MapperComision>())
            {
                ls.Add(mapper(obj));
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
