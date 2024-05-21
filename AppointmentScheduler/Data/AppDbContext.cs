using Microsoft.EntityFrameworkCore;
using AppointmentScheduler.Models;

namespace AppointmentScheduler.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }    
    }
}
