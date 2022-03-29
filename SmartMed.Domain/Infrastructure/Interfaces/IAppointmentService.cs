using SmartMed.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMed.Domain.Infrastructure.Interfaces
{
    public interface IAppointmentService
    {
        public IEnumerable<Appointment> GetAll();

        public Appointment GetById(Guid id);

        public Status GetStatus(Guid id);
    }
}
