using System.Threading.Tasks;
using VaccineApp.DTO;

namespace VaccineApp.Services
{
    public interface IAccountService
    {
        Task<AccountDto> LoginAsync(string email, string password);
        Task<AccountDto> RegisterAsync(RegisterDto registerDto);
        Task<bool> UserExists(string email);
    }
}