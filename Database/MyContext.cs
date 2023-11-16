using Microsoft.EntityFrameworkCore;
using BookServicesAPI.Entity;

namespace BookServicesAPI.Database
{
    public class MyContext : DbContext
    {
        public DbSet<Books > Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= DESKTOP-30U1UJQ\\SQLEXPRESS01; Initial Catalog=BooksService;User Id=Varaprasad;Password=12345;TrustServerCertificate=true");
        }

    }
}
