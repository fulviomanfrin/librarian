using Domain.Models;
using InfraData.Repository.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfraData.Repository
{
    public class BookRepository : IBookRepository
    {

        private readonly IRepository<Book> _repository;


        public BookRepository(IRepository<Book> repository)
        {
            _repository = repository;
            
        }

        // Method responsible for returning all Books,
        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }
                
        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }

        
        public Book Create(Book book)
        {
            _repository.Create(book);
            return book;
        }

        
        public Book Update(Book book)
        {

            _repository.Update(book);
            return book;
        }

        // Method responsible for deleting a book from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
      
    }
}
