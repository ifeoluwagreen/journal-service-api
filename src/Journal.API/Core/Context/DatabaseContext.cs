using Microsoft.EntityFrameworkCore;
using Journal.API.Core.Models;

namespace Journal.API.Core.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Journall> Journals { get; set; }
        public DbSet<JournalEntry> JournalEntries { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
