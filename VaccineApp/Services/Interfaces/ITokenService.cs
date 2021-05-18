using VaccineApp.Entities;

namespace VaccineApp.Services
{
    public interface ITokenService
    {
        string CreateToken(Login login);
    }
}