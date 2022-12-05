namespace BibliotecaLabBanco.Repository.Interfaces;

public interface IBaseRepository<T, TId>
{
    Task<T> CreateAsync(T entity);
    Task<T> GetByIdAsync(TId id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(TId id);
}
