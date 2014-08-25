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
    public class DaoTipo
    {
        private MongoCollection<Tipo> tipos;

        public DaoTipo()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            tipos = database.GetCollection<Tipo>("test");
        }

        public void insert(Tipo tipo)
        {
            tipos.Insert(tipo);
        }

        public Tipo findOne(int id) 
        {
            var query = new QueryDocument("_id", id);
            foreach (Tipo t in tipos.Find(query))
            {
                return t;
            }
            return new Tipo();
        }

    }
}
