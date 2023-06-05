using Microsoft.EntityFrameworkCore;
using sac_biblioteca_generation.Models;

namespace sac_biblioteca_generation.Database
{
    public class BookShopContext : DbContext
    {       
        public DbSet<Book> Books { get; set; }
        public DbSet<BookGenre> Genre { get; set; }
        public DbSet<Authors> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BookShop;" +
                "Integrated Security=True;TrustServerCertificate=True");
        }

    }
}
