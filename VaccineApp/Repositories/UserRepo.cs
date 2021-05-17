using System.Collections.Generic;
using System.Threading.Tasks;

using VaccineApp.Entities;

namespace VaccineApp.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Server.IIS.Core;
    using Microsoft.EntityFrameworkCore;

    using VaccineApp.Entities;

    public class UserRepo : IUserRepo
    {
        private DatabaseContext _context;

        public UserRepo(DatabaseContext context) => _context = context;

        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = new User { Id = id };
            _context.Attach(user);
            _context.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await _context.Users.Include(x => x.Appointments).Include(y => y.Login)
                       .FirstOrDefaultAsync(user => user.Id == id);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Users.Include(x => x.Appointments).Include(y => y.Login).ToListAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}