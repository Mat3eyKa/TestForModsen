using Microsoft.EntityFrameworkCore;
using TestForModsen.Models;

namespace TestForModsen.Data
{
    public class ModsenContext : DbContext
    {
        public ModsenContext(DbContextOptions<ModsenContext> options)
            : base(options) { Database.EnsureCreated(); }
        public DbSet<Event> Events { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Event>(entity => entity.ToTable(name: "Events"));
        }
    }
}
