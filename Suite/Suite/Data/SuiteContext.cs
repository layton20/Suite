using Microsoft.EntityFrameworkCore;
using Suite.Models;

namespace Suite.Data
{
    public class SuiteContext : DbContext
    {
        public SuiteContext (DbContextOptions<SuiteContext> options): base(options){ }

        public DbSet<Tag> Tag { get; set; } = default!;
    }
}