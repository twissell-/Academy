using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson;
using MongoDB.Driver;

namespace Data
{
    class Connection
    {
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
                    Instance = new Connection();
                }
                return Instance;
            }
        }
    }
}
