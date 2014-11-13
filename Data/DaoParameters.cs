using System.Collections.Generic;
using Entidades;
using MongoDB.Driver;

namespace Data
{
    public class DaoParameter
    {
        // Singleton
        private static DaoParameter Instance;
        MongoCollection Parameters;

        private DaoParameter()
        {
            MongoServer server = Connection.instance.server;
            MongoDatabase database = server.GetDatabase("test");
            Parameters = database.GetCollection<Param>("parametros");
        }

        public static DaoParameter instance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new DaoParameter();
                }
                return Instance;
            }
        }

        private int getParameterValue(string id)
        {
            Param p = this.find(id);
            int val = p.value;
            p.value += 1;
            this.save(p);

            return val;
        }

        #region Interfaces para los distintos parametros

        public int getAlumnoNextId()
        {
            return getParameterValue("alumnoNextId");
        }

        public int getComisionNextId()
        {
            return getParameterValue("comisionNextId");
        }

        public int getDocenteNextId()
        {
            return getParameterValue("docenteNextId");
        }

        public int getEspecialidadNextId()
        {
            return getParameterValue("especialidadNextId");
        }

        public int getMateriaNextId()
        {
            return getParameterValue("materiaNextId");
        }

        public int getPlanNextId()
        {
            return getParameterValue("planNextId");
        }

        public int getAdministrativoNextId()
        {
            return getParameterValue("administrativoNextId");
        }

        #endregion

        private void save(Param obj)
        {
            Parameters.Save(obj);
        }

        private Param find(string id)
        {
            QueryDocument query = new QueryDocument("_id", id);
            return Parameters.FindOneAs<Param>(query);
        }

        private void delete(Param obj)
        {
            QueryDocument query = new QueryDocument("_id", obj.id);
            Parameters.Remove(query);
        }

        private void update(Param obj)
        {
            save(obj);
        }

        private void insert(Param obj)
        {
            save(obj);
        }

    }
}
