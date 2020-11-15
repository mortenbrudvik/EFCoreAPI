using ApplicationCore;
using Shouldly;
using Xunit;

namespace IntegrationTests
{
    public class DatabaseTests
    {
        public DatabaseTests()
        {
            using var context = new ApplicationDbContextMock();
            context.Database.EnsureCreated();
        }
        [Fact]
        public void CanInsertAuthorIntoDb()
        {
            using var context = new ApplicationDbContextMock();

            var author = new Author {Name = "Peter F. Hamilton"};
            context.Authors.Add(author);

            context.SaveChanges();

            author.Id.ShouldNotBe(0);
        }

        ~DatabaseTests()
        {
            using var context = new ApplicationDbContextMock();
            context.Database.EnsureDeleted();
        }
    }
}
