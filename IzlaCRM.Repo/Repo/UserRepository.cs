using IzlaCRM.DAL;
using IzlaCRM.Entity.Entities;
using IzlaCRM.Repo.IRepo;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Repo.Repo
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
         
        }

        public User? Finduser(string email, string password)
        {
             var res=DbSet.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
            return res is null ? null:res ;
        }
        public List<User?> GetUserbyTenant(int TenantId)
        {
            var res = DbSet.Where(x => x.TenantId == TenantId).ToList(); 
            return res is null ? null : res;
        }
    }

}
