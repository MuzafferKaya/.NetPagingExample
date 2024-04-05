using Microsoft.EntityFrameworkCore;
using PagingExample.Entities;

namespace PagingExample.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Owner> Owners { get; set; }
    }
}
