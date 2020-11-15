using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace IntegrationTests
{
    public class ApplicationDbContextMock : ApplicationDbContext
    {
        public ApplicationDbContextMock()
        {
            
        }
        public ApplicationDbContextMock(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BookDataTest");
        }
    }
}