using IzlaCRM.Entity.Entities;
using IzlaCRM.Repo.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Repo.IRepo
{
    public interface IUserRepository : IGenericRepository<User>
    {

        User? Finduser(string email, string password);
        List<User?> GetUserbyTenant(int TenantId);
    }
}
