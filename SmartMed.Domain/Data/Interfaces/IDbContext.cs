using Microsoft.EntityFrameworkCore;
using SmartMed.Domain.Models;

namespace SmartMed.Domain.Data.Interfaces
{
    public interface IDbContext
    {
        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Option> Options { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public int SaveChanges();
    }
}
