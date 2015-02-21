using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Data
{
    class Connection
    {
        // Singleton
        private static Connection Instance;

        public MongoServer server { get; set; }

        private Connection() 
        {
            String connectionString = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionString);
            server = client.GetServer();
       }

        public static Connection instance
        {
            get
            {
                if (Instance == null)
                {
                    try
                    {
                        Instance = new Connection();
                    }
                    catch (MongoConnectionException e)
                    {
                        throw new AppConnectionException();
                    }
                }
                return Instance;
            }
        }
    }
}
