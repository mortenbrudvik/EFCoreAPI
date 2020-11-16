using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace IntegrationTests
{
    public class ApplicationDbContextMock : ApplicationDbContext
    {
        public ApplicationDbContextMock() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BookDataTest");
        }
    }
}