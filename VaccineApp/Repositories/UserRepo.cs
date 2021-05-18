namespace VaccineApp.Repositories
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class UserRepo : GenericRepo<User>
    {
        public UserRepo(DatabaseContext context)
            : base(context)
        {
        }

        public override async Task<User> GetAsync(int id)
        {
            return await _context.Users
                .Include(x => x.Appointments)
                    .ThenInclude(x => x.Vaccination)
                        .ThenInclude(x => x.BodyPart)
                .Include(x => x.Appointments)
                .ThenInclude(x => x.Status)
                .Include(x => x.Appointments)
                    .ThenInclude(x => x.Vaccination)
                    .ThenInclude(x => x.Company)
                .Include(x => x.Appointments)
                    .ThenInclude(x => x.Location)
                .Include(x => x.Login)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public override async Task<List<User>> GetAllAsync()
        {
            return await _context.Users
                .Include(x => x.Appointments)
                    .ThenInclude(x => x.Vaccination)
                        .ThenInclude(x => x.BodyPart)
                .Include(x => x.Appointments)
                .ThenInclude(x => x.Status)
                .Include(x => x.Appointments)
                    .ThenInclude(x => x.Vaccination)
                    .ThenInclude(x => x.Company)
                .Include(x => x.Appointments)
                    .ThenInclude(x => x.Location)
                .Include(x => x.Login)
                .ToListAsync();
        }
    }
}