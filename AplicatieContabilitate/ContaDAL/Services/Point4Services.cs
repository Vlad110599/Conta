using ContaDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDAL.Services
{
    public class Point4Services
    {
        public void AddPunct4(Punct4 punct)
        {

            using (var context = new MasterContext())
            {
                context.Set<Punct4>().Add(punct);
                context.SaveChanges();
            }

        }

        public List<Punct4> GetPoint4()
        {
            using (var context = new MasterContext())
            {
                return context.Point4.ToList();
            }

        }

        public void Update(Punct4 punct)
        {
            using (var context = new MasterContext())
            {
                context.Entry(punct).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteClient(Punct4 punct)
        {
            using (var context = new MasterContext())
            {
                context.Entry(punct).State = EntityState.Deleted;
                context.SaveChanges();
            }

        }


    }
}