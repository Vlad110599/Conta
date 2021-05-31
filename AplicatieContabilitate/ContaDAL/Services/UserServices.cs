using ContaDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDAL.Services
{
    class UserServices
    {
        public void AddUser(User user)
        {

            using (var context = new MasterContext())
            {
                context.Set<User>().Add(user);
                context.SaveChanges();
            }

        }

        public List<User> GetUser()
        {
            using (var context = new MasterContext())
            {
                return context.Utilizator.ToList();
            }

        }

        public void Update(User user)
        {
            using (var context = new MasterContext())
            {
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteClient(User user)
        {
            using (var context = new MasterContext())
            {
                context.Entry(user).State = EntityState.Deleted;
                context.SaveChanges();
            }

        }
    }
}
