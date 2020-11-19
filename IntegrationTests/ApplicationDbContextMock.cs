using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace IntegrationTests
{
    public class ApplicationDbContextMock : ApplicationDbContext
    {
        public ApplicationDbContextMock() { }

        public ApplicationDbContextMock(DbContextOptions options) : base(options)
        {
            IsMemoryDb = true;
        }

        public bool IsMemoryDb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!IsMemoryDb)
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BookDataTest");
        }
    }
}