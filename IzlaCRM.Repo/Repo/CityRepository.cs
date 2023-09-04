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
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }
        public IEnumerable<City> GetCitiesByCountryId(int CountryId)
        {
            var res = DbSet.Where(p => p.CountryId == CountryId  && p.IsActive==true );
            return res;

        }
    }
}
