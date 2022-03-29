using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartMed.Domain.Data.Interfaces;
using SmartMed.Domain.Models;
using System;

namespace SmartMed.Domain.Data
{
    public class MsSqlDbContext : IdentityDbContext<User, Role, Guid>, IDbContext
    {
        public MsSqlDbContext(DbContextOptions<MsSqlDbContext> options) : base(options)
        {

        }
        new public DbSet<User> Users { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Option> Options { get; set; }

        public DbSet<Status> Statuses { get; set; }

        protected override async void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DataSeed seed = new DataSeed();

            builder.Entity<Rating>().HasData(seed.ratings);
            builder.Entity<Option>().HasData(seed.options);
            builder.Entity<Feedback>().HasData(seed.feedbacks);
            builder.Entity<Status>().HasData(seed.statuses);
            builder.Entity<User>().HasData(seed.users);
            builder.Entity<Appointment>().HasData(seed.appointments);
        }
    }
}
