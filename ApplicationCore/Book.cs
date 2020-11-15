using System.Collections.Generic;
using System.ComponentModel;

namespace ApplicationCore
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public List<Author> Authors { get; set; }
        public string ISBN13 { get; set; }
        public BookType Type { get; set; }

    }
}