using System.Collections.Generic;
using Entidades;
using Util;
using MongoDB.Driver;

using Entidades;

namespace Data
{
    public class DaoComision
    {
        private MongoCollection<MapperComision> comisiones;

        public DaoComision()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            comisiones = database.GetCollection<MapperComision>("comisiones");  
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

            List<Alumno> alumnos = new List<Alumno>();
            //  recupero los objetos Alumno
            foreach (MapperEstado aux in mapper.alumnos)
            {
                Alumno a = (Alumno)da.find(aux.id);
                a.condicion = aux.estado;
                alumnos.Add(a);
            }
            //  Recupero los objetos Docente
            List<Docente> docentes = new List<Docente>();
            foreach (MapperEstado aux in mapper.docentes)
            {
                Docente d = (Docente)dd.find(aux.id);
                d.cargo = aux.estado;
                docentes.Add(d);
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

        public List<Comision> find(Materia m)
        {
            List<Comision> ls = new List<Comision>();
            QueryDocument query = new QueryDocument("materia", m.id);
            foreach (MapperComision obj in comisiones.Find(query))
            {
                ls.Add(mapper(obj));
            }
            return ls;
        }

        public List<Comision> find(Docente d)
        {
            List<Comision> ls = new List<Comision>();
            QueryDocument query = new QueryDocument("docentes._id", d.id);
            foreach (MapperComision obj in comisiones.Find(query))
            {
                ls.Add(mapper(obj));
            }
            return ls;
        }

        public List<Comision> find(Alumno a)
        {
            List<Comision> ls = new List<Comision>();
            QueryDocument query = new QueryDocument("alumnos._id", a.id);
            foreach (MapperComision obj in comisiones.Find(query))
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
            if (obj.id == 0)
            {
                obj.id = DaoParameter.instance.getComisionNextId();
            }
            save(obj);
        }

    }
}
