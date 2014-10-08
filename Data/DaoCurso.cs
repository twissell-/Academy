using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entidades;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;

namespace Data
{
    public class DaoCurso
    {
        private MongoCollection<Curso> Cursos;

        public DaoCurso()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            Cursos = database.GetCollection<Curso>("test");  
        }

        private void save(Curso obj)
        {
            Cursos.Save(obj);
        }

        public Curso find(int id) 
        {
            QueryDocument query = new QueryDocument("_id", id);
            return Cursos.FindOneAs<Curso>(query);
        }

        public List<Curso> find()
        {
            List<Curso> ls = new List<Curso>();
            foreach (Curso obj in Cursos.FindAllAs<Curso>())
            {
                ls.Add(obj);
            }
            return ls;
        }

        public void delete(Curso obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            Cursos.Remove(query);
        }

        public void update(Curso obj)
        {
            save(obj);
        }

        public void insert(Curso obj)
        {
            save(obj);
        }
    }
}
