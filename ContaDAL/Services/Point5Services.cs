using ContaDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDAL.Services
{
    public class Point5Services
    {
        public void AddPunct5(Punct5 punct)
        {

            using (var context = new MasterContext())
            {
                context.Set<Punct5>().Add(punct);
                context.SaveChanges();
            }

        }

        public List<Punct5> GetPoint5()
        {
            using (var context = new MasterContext())
            {
                return context.Point5.ToList();
            }

        }

        public void Update(Punct5 punct)
        {
            using (var context = new MasterContext())
            {
                context.Entry(punct).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteClient(Punct5 punct)
        {
            using (var context = new MasterContext())
            {
                context.Entry(punct).State = EntityState.Deleted;
                context.SaveChanges();
            }

        }


    }
}
