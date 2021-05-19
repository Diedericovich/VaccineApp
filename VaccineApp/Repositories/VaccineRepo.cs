namespace VaccineApp.Repositories
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class VaccineRepo : GenericRepo<Vaccine>, IVaccineRepo
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

        public async Task<List<Vaccine>> GetAllByPartAsync(string part)
        {
            if (part == "Head")
            {
                return await _context.Vaccines
                    .Include(x => x.BodyPart)
                    .Include(x => x.Company)
                    .Where(x => x.BodyPart.Name == "Nose" || x.BodyPart.Name == "Mouth" || x.BodyPart.Name == "Ears" || x.BodyPart.Name == "Eyes")
                    .ToListAsync();
            }
            else
            {
                return await _context.Vaccines
                    .Include(x => x.BodyPart)
                    .Include(x => x.Company)
                    .Where(x => x.BodyPart.Name == part)
                    .ToListAsync();
            }
        }
    }
}