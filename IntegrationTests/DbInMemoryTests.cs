using ApplicationCore;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Xunit;

namespace IntegrationTests
{
    public class DbInMemoryTests
    {
        [Fact]
        public void CanInsertAuthorIntoDb()
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase("MemDb");
            using var context = new ApplicationDbContext(builder.Options);

            var author = new Author {Name = "Peter F. Hamilton"};
            context.Authors.Add(author);

            context.Entry(author).State.ShouldBe(EntityState.Added);
        }
    }
}