using AspNetStore.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
