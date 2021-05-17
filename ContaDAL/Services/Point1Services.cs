using ContaDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDAL.Services
{
    public class Point1Services
    {
        public void AddPunct1(Punct1 punct)
        {

            using (var context = new MasterContext())
            {
                context.Set<Punct1>().Add(punct);
                context.SaveChanges();
            }

        }

        public List<Punct1> GetPoint1()
        {
            using (var context = new MasterContext())
            {
                return context.Point1.ToList();
            }

        }

        public void Update(Punct1 punct)
        {
            using (var context = new MasterContext())
            {
                context.Entry(punct).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteClient(Punct1 punct)
        {
            using (var context = new MasterContext())
            {
                context.Entry(punct).State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

    
    }
}
