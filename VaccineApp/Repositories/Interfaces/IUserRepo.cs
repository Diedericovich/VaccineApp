using System.Collections.Generic;
using System.Threading.Tasks;
using VaccineApp.Entities;

namespace VaccineApp.Repositories
{
    public interface IUserRepo
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetAsync(int id);
        Task<User> GetUserByEmail(string email);
        Task AddAsync(User user);
        Task DeleteAsync(int id);
        Task UpdateAsync(User user);
    }
}