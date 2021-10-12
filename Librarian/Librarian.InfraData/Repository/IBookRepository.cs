using Domain.Models;
using InfraData.Repository.Generic;
using System.Collections.Generic;

namespace InfraData.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book FindById(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);
    }
}
