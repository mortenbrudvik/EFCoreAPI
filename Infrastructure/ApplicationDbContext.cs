using ApplicationCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookType> BookTypes { get; set; }

        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions options) : base(options){}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().Property(a => a.Name).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
    }
}