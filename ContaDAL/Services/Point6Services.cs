using ContaDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDAL.Services
{
    public class Point6Services
    {
        public void AddPunct6(Punct6 punct)
        {

            using (var context = new MasterContext())
            {
                context.Set<Punct6>().Add(punct);
                context.SaveChanges();
            }

        }

        public List<Punct6> GetPoint6()
        {
            using (var context = new MasterContext())
            {
                return context.Point6.ToList();
            }

        }

        public void Update(Punct6 punct)
        {
            using (var context = new MasterContext())
            {
                context.Entry(punct).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteClient(Punct6 punct)
        {
            using (var context = new MasterContext())
            {
                context.Entry(punct).State = EntityState.Deleted;
                context.SaveChanges();
            }

        }


    }
}
