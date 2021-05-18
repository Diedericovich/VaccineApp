namespace VaccineApp.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection.PortableExecutable;
    using System.Threading.Tasks;

    using Entities;

    using Microsoft.EntityFrameworkCore;

    public class VaccineRepo : GenericRepo<Vaccine>
    {
        public VaccineRepo(DatabaseContext context)
            : base(context)
        {
        }

        public override async Task<Vaccine> GetAsync(int id)
        {
            return await _context.Vaccines
                .Include(x => x.BodyPart)
                .Include(x => x.Company)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public override async Task<List<Vaccine>> GetAllAsync()
        {
            return await _context.Vaccines
                .Include(x => x.BodyPart)
                .Include(x => x.Company)
                .ToListAsync();
        }
    }
}