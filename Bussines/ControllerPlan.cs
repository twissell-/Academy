using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Entidades;

namespace Bussines
{
    public class ControllerPlan
    {
        private DaoPlan dao;

        public ControllerPlan()
        {
            dao = new DaoPlan();
        }

        public Plan find(int id)
        {
            return dao.find(id);
        }

        public List<Plan> find()
        {
            return dao.find();
        }

        public void delete(Plan obj)
        {
            dao.delete(obj);
        }

        public void update(Plan obj)
        {
            dao.update(obj);
        }

        public void insert(Plan obj)
        {
            dao.insert(obj);
        }
    }
}