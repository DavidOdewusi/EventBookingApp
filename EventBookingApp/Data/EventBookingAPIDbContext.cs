using EventBookingApp.Model;
using Microsoft.EntityFrameworkCore;

namespace EventBookingApp.Data
{
    public class EventBookingAPIDbContext : DbContext
    {
        public EventBookingAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
