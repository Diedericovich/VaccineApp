using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccineApp.Entities;

namespace VaccineApp.Repositories
{
    public class VaccinationCenterRepo : GenericRepo<VaccinationCenterRepo>, IVaccinationCenterRepo
    {
        public VaccinationCenterRepo(DatabaseContext context)
            : base(context)
        {
        }

        public async Task<List<VaccinationCenter>> GetRandomItem(int amount)
        {
            return await _context.VaccinationCenters.OrderBy(r => Guid.NewGuid()).Take(amount).ToListAsync();
        }
    }
}