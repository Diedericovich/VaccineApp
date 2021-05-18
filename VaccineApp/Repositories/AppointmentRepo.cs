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

    public class AppointmentRepo : IAppointmentRepo
    {
        private DatabaseContext _context;

        public AppointmentRepo(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Appointment> GetAppointmentAsync(int id)
        {
            return await _context.Appointments
                                 .Include(x => x.Location)
                                 .Include(z => z.Vaccination)
                                 .Include(y => y.Status)
                                 .FirstOrDefaultAsync();
        }

        public async Task<List<Appointment>> GetAppointmentsAsync()
        {
            return await _context.Appointments
                                 .Include(x => x.Location)
                                 .Include(z => z.Vaccination)
                                 .Include(y => y.Status)
                                 .ToListAsync();
        }

        public async Task AddAppointmentAsync(Appointment appointment)
        {
            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            var appointment = new Appointment() { Id = id };
            _context.Attach(appointment);
            _context.Remove(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            await _context.SaveChangesAsync();
        }
    }
}