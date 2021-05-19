using System.Collections.Generic;
using System.Threading.Tasks;
using VaccineApp.DTO;

namespace VaccineApp.Services
{
    public interface IUserService
    {
        Task AddUserAsync(UserDto user);

        Task DeleteUserAsync(int id);

        Task<UserDto> GetUserAsync(int id);

        Task<List<UserDto>> GetUsersAsync();

        Task UpdateUserAsync(UserDto user);

        Task<UserDto> GetUserByEmailAsync(string email);
    }
}