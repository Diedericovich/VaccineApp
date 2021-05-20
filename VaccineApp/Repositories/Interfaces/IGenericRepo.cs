using System.Collections.Generic;
using System.Threading.Tasks;

namespace VaccineApp.Repositories
{
    public interface IGenericRepo<T> where T : class
    {
        Task AddAsync(T item);

        Task DeleteAsync(int id);

        Task<T> GetAsync(int id);

        Task<List<T>> GetAllAsync();

        Task UpdateAsync(T item);
    }
}