using System;
using System.Linq;
using System.Threading.Tasks;
using VaccineApp.Entities;
using VaccineApp.Repositories;

namespace VaccineApp.Services
{
    public class AppointmentDataService : IAppointmentDataService
    {
        private IUserRepo _userRepo;
        private IVaccinationCenterRepo _centerRepo;

        public AppointmentDataService(IUserRepo userRepo, IVaccinationCenterRepo centerRepo)
        {
            _userRepo = userRepo;
            _centerRepo = centerRepo;
        }

        public async Task<DateTime> GetAppointmentDateAsync(int userId)
        {
            var rand = new Random();
            var user = await _userRepo.GetAsync(userId);
            if (user.Appointments.Count <= 0)
            {
                var date = DateTime.Now.Date.Add(new TimeSpan(rand.Next(9, 18), rand.Next(0, 60), 0)).AddDays(rand.Next(7, 14));
                return date;
            }
            else
            {
                var date = user.Appointments.FindLast(x => x.StatusId == 1).Date.AddDays(rand.Next(14, 28));
                TimeSpan ts = new TimeSpan(rand.Next(9, 18), rand.Next(0, 60), 0);
                date = date.Date + ts;
                return date;
            }
        }

        public async Task<VaccinationCenter> GetVaccinationCenterAsync(int userId)
        {
            var user = await _userRepo.GetAsync(userId);
            if (user.Appointments.Count <= 0)
            {
                return await ReturnRandomVaccinationCenterAsync();
            }
            else
            {
                return await CheckForAvailableVaccinationCenterAsync(user);
            }
        }

        private async Task<VaccinationCenter> CheckForAvailableVaccinationCenterAsync(User user)
        {
            var rand = new Random();
            if (rand.Next(0, 15) <= 10)
            {
                return user.Appointments.Last().Location;
            }
            else
            {
                return await ReturnRandomVaccinationCenterAsync();
            }
        }

        private async Task<VaccinationCenter> ReturnRandomVaccinationCenterAsync()
        {
            var location = await _centerRepo.GetRandomItem(1);
            return location[0];
        }
    }
}