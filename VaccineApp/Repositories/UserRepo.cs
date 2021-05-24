﻿namespace VaccineApp.Repositories
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class UserRepo : GenericRepo<User>, IUserRepo
    {
        public UserRepo(DatabaseContext context)
            : base(context)
        {
        }

        public override async Task<User> GetAsync(int id)
        {
            return await _context.Users
                .Include(x => x.Login)
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

        public async Task<User> GetUserByEmail(string email)
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
                .FirstOrDefaultAsync(x => x.Email == email);
        }

        public override async Task UpdateAsync(User item)
        {
            _context.Entry(item).Property(x => x.Email).IsModified = true;
            _context.Entry(item).Property(x => x.FirstName).IsModified = true;
            _context.Entry(item).Property(x => x.Surname).IsModified = true;
            _context.Entry(item).Property(x => x.Address).IsModified = true;
            _context.Entry(item).Property(x => x.BirthDate).IsModified = true;
            await _context.SaveChangesAsync();
        }
    }
}