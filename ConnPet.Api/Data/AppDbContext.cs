using System.Reflection;
using ConnPet.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ConnPet.Api.Data
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Clinic> Clinics { get; set; } = null!;
        public DbSet<Consultation> Consultations { get; set; } = null!;
        public DbSet<Pet> Pets { get; set; } = null!;
        public DbSet<Tutor> Tutors { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        override protected void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
