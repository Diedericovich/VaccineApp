namespace VaccineApp.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection.PortableExecutable;
    using System.Threading.Tasks;

    using Entities;

    using Microsoft.EntityFrameworkCore;

    public class VaccineRepo : IVaccineRepo
    {
        private DatabaseContext _context;

        public VaccineRepo(DatabaseContext context)
        {
            _context = context;
        }

        public async Task AddVaccineAsync(Vaccine vaccine)
        {
            await _context.Vaccines.AddAsync(vaccine);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteVaccineAsync(int id)
        {
            var vaccine = new Vaccine() { Id = id };
            _context.Attach(vaccine);
            _context.Remove(vaccine);
            await _context.SaveChangesAsync();
        }

        public async Task<Vaccine> GetVaccineAsync(int id)
        {
            return await _context.Vaccines
                                 .Include(x => x.Company)
                                 .Include(y => y.BodyPart)
                                 .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Vaccine>> GetVaccinesAsync()
        {
            return await _context.Vaccines
                                 .Include(x => x.Company)
                                 .Include(y => y.BodyPart)
                                 .ToListAsync();
        }

        public async Task UpdateVaccineAsync(Vaccine vaccine)
        {
            _context.Vaccines.Update(vaccine);
            await _context.SaveChangesAsync();
        }
    }
}