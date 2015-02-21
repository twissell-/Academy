using System.Collections.Generic;
using Entidades;
using MongoDB.Driver;
using System.Net.Sockets;
namespace Data
{
    public class DaoAlumno : IDaoPersona
    {
        private MongoCollection<Alumno> alumnos;

        public DaoAlumno()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            alumnos = database.GetCollection<Alumno>("alumnos");  
        }

        private void save(Persona obj)
        {
            alumnos.Save((Alumno)obj);
        }

        public Persona find(int id) 
        {
            try
            {
                QueryDocument query = new QueryDocument("_id", id);
                return (Persona)alumnos.FindOneAs<Alumno>(query);
            }
            catch (MongoConnectionException)
            {
                throw new AppConnectionException();
            }
            catch (SocketException)
            {
                throw new AppConnectionException();
            }
        }

        public List<Persona> find()
        {
            List<Persona> ls = new List<Persona>();
            foreach (Alumno obj in alumnos.FindAllAs<Alumno>())
            {
                ls.Add((Persona)obj);
            }
            return ls;
        }

        public void delete(Persona obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            alumnos.Remove(query);
        }

        public void update(Persona obj)
        {
            save(obj);
        }

        public void insert(Persona obj)
        {
            if (obj.id == 0)
            {
                obj.id = DaoParameter.instance.getAlumnoNextId();
            }
            save(obj);
        }

    }
}
