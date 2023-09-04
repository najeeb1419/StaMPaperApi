namespace IzlaCRM.Repo.IRepo
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(int TenantId);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task AddAsync(List<T> entities);
        Task UpdateAsync(T entity);
        Task Delete(int id);
    }
}
