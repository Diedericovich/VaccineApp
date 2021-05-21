namespace VaccineApp.Services.Interfaces
{
    using System.Threading.Tasks;
    using DTO;
    using Microsoft.AspNetCore.Mvc;

    public interface IAccountService
    {
        Task<AccountDto> LoginAsync(string email, string password);
        Task<AccountDto> RegisterAsync(RegisterDto registerDto);
        Task<bool> UserExists(string email);
        Task UpdateUserPassword(string email, string newpassword);

    }
}