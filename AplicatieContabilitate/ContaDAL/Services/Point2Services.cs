using ContaDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDAL.Services
{
    public class Point2Services
    {
        public void AddPunct2(Punct2 punct)
        {

            using (var context = new MasterContext())
            {
                context.Set<Punct2>().Add(punct);
                context.SaveChanges();
            }

        }

        public List<Punct2> GetPoint2()
        {
            using (var context = new MasterContext())
            {
                return context.Point2.ToList();
            }

        }

        public void Update(Punct2 punct)
        {
            using (var context = new MasterContext())
            {
                context.Entry(punct).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteClient(Punct2 punct)
        {
            using (var context = new MasterContext())
            {
                context.Entry(punct).State = EntityState.Deleted;
                context.SaveChanges();
            }

        }


    }
}
