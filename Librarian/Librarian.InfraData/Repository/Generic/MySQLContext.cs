using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Librarian.Data
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }
        
        public MySQLContext(DbContextOptions<MySQLContext> opt) : base (opt)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
