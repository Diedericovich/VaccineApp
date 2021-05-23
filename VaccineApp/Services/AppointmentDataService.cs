using System;
using System.Collections.Generic;
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
                var date = user.Appointments.Last().Date.AddDays(rand.Next(14, 28));
                return date;
            }
        }

        public async Task<VaccinationCenter> GetVaccinationCenterAsync(int userId)
        {
            var user = await _userRepo.GetAsync(userId);
            if (user.Appointments.Count <= 0)
            {
                var location = await _centerRepo.GetRandomItem(1);
                return location[0];
            }
            else
            {
                return user.Appointments.Last().Location;
            }
        }
    }
}