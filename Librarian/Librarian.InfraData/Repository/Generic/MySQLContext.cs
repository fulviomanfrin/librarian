using Domain.Models;
using Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;

namespace InfraData.Repository.Generic
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

        internal BaseEntity SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
