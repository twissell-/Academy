using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entidades;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Data
{
    public class DaoTipo
    {
        public void addOne(Tipo tipo)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("test");
            var collection = database.GetCollection("test");

            collection.Insert(tipo);
        }

    }
}
