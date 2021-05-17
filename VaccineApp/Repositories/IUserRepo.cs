namespace VaccineApp.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using VaccineApp.Entities;

    public interface IUserRepo
    {
        Task AddUserAsync(User user);

        Task DeleteUserAsync(int id);

        Task<User> GetUserAsync(int id);

        Task<List<User>> GetUsersAsync();

        Task UpdateUserAsync(User user);
    }
}