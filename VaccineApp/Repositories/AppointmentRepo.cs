namespace VaccineApp.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;

    using Entities;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class AppointmentRepo : GenericRepo<Appointment>
    {
        public AppointmentRepo(DatabaseContext context)
            : base(context)
        {
        }

        public override async Task<Appointment> GetAsync(int id)
        {
            return await _context.Appointments
                                 .Include(x => x.Location)
                                 .Include(x => x.Vaccination)
                                    .ThenInclude(x => x.BodyPart)
                                 .Include(x => x.Status)
                                 .FirstOrDefaultAsync(x => x.Id == id);
        }

        public override async Task<List<Appointment>> GetAllAsync()
        {
            return await _context.Appointments
                                 .Include(x => x.Location)
                                 .Include(x => x.Vaccination)
                                 .Include(x => x.Status)
                                 .ToListAsync();
        }
    }
}