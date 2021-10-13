using Domain.Models;
using InfraData.Repository.Generic;

namespace InfraData.Repository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {                
        public BookRepository(MySQLContext context): base(context)
        {
           
            
        }              
    }
}
