using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Librarian.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> opt) : base (opt)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
