using Microsoft.EntityFrameworkCore;
using TestDb.Models;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        {
        }

        // Déclaration des DbSet
        public DbSet<Product> Products { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}