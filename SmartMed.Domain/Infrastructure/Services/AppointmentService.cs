using SmartMed.Domain.Data.Interfaces;
using SmartMed.Domain.Infrastructure.Interfaces;
using SmartMed.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SmartMed.Domain.Infrastructure.Services
{
    public class AppointmentService : IAppointmentService
    {
        private IDbContext _context;

        public AppointmentService(IDbContext context)
        {
            _context = context;    
        }

        public Status GetStatus(Guid id)
        {
            return GetById(id).Status;
        }

        public IEnumerable<Appointment> GetAll() => 
            _context.Appointments;       

        public Appointment GetById(Guid id)
        {
            return _context.Appointments
                .Include(a => a.Feedback)
                .Where(a => a.Id == id)
                .FirstOrDefault();
        }
    }
}
