using System;
using System.Threading.Tasks;
using VaccineApp.Entities;

namespace VaccineApp.Services
{
    public interface IAppointmentDataService
    {
        Task<DateTime> GetAppointmentDateAsync(int userId);

        Task<VaccinationCenter> GetVaccinationCenterAsync(int userId);
    }
}