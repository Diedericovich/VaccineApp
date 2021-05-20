using System.Threading.Tasks;
using VaccineApp.DTO;

namespace VaccineApp.Services
{
    public interface IGeoCodeService
    {
        Task<LocationDto> GetLocation(string address);
    }
}