using Microsoft.EntityFrameworkCore;
using Volunteer.Core;

namespace Volunteer.Api.Data
{
    public class VolunteerContext : DbContext
    {
        public VolunteerContext() { }

        public VolunteerContext(DbContextOptions<VolunteerContext> options)
           : base(options) { }

        public DbSet<Listing> Listings { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
