using IzlaCRM.DAL;
using IzlaCRM.Entity.Common;
using IzlaCRM.Repo.IRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace IzlaCRM.Repo.Repo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly ILogger _logger;
        internal ApplicationDbContext Dbcontext;
        internal DbSet<T> DbSet;


        public GenericRepository(ApplicationDbContext context, ILogger logger)
        {
            Dbcontext = context;
            DbSet = Dbcontext.Set<T>();
            _logger = logger;
        }


        public async Task<IEnumerable<T>> GetAllAsync(int tenantId)
        {
            if (typeof(IMustHaveTenant).IsAssignableFrom(typeof(T)))
            {
                var tenantEntities = await DbSet.Cast<IMustHaveTenant>().Where(entity => entity.TenantId == tenantId).ToListAsync();
                return tenantEntities.Cast<T>();
            }
            else
            {
                return await DbSet.ToListAsync();
            }
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            //var entity =  await (DbSet.Cast<IDeleted>().Where(x=>x.IsDeleted==false).ToListAsync());
            //return entity.Cast<T>();

            return await DbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);

        }

        public async Task AddAsync(T entity)
        {
            Type baseEntityInfo = typeof(T);
            PropertyInfo CreationTimeField = baseEntityInfo.GetProperty("CreationTime");
            if (CreationTimeField != null)
            {
                CreationTimeField.SetValue(entity, DateTime.Now);
            }
            await DbSet.AddAsync(entity);
        }
        public async Task AddAsync(List<T> entities)
        {

            await DbSet.AddRangeAsync(entities);
        }

        public Task UpdateAsync(T entity)
        {
            DbSet.Update(entity);
            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            T entity = DbSet.Find(id);
            Type baseEntityInfo = typeof(T);
            PropertyInfo IsDeletedField = baseEntityInfo.GetProperty("IsDeleted");
            if (IsDeletedField != null)
            {
                IsDeletedField.SetValue(entity, true);
            }

            PropertyInfo DeletionTimeField = baseEntityInfo.GetProperty("DeletionTime");
            if (DeletionTimeField != null)
            {
                DeletionTimeField.SetValue(entity, DateTime.Now);
            }
            PropertyInfo IsActive = baseEntityInfo.GetProperty("IsActive");
            IsActive.SetValue(entity, false);
            DbSet.Update(entity);
            return Task.CompletedTask;
        }
    }
}
