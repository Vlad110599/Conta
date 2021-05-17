using ContaDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDAL.Services
{
    public class Point3Services
    {
        public void AddPunct3(Punct3 punct)
        {

            using (var context = new MasterContext())
            {
                context.Set<Punct3>().Add(punct);
                context.SaveChanges();
            }

        }

        public List<Punct3> GetPoint3()
        {
            using (var context = new MasterContext())
            {
                return context.Point3.ToList();
            }

        }

        public void Update(Punct3 punct)
        {
            using (var context = new MasterContext())
            {
                context.Entry(punct).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteClient(Punct3 punct)
        {
            using (var context = new MasterContext())
            {
                context.Entry(punct).State = EntityState.Deleted;
                context.SaveChanges();
            }

        }


    }
}