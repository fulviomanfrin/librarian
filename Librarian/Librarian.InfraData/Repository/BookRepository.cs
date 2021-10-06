using Domain.Models;
using Domain.Models.Base;
using InfraData.Repository.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraData.Repository
{
    public class BookRepository : IBookRepository
    {

        private MySQLContext _context;

        private DbSet<Book> dataset;

        public BookRepository(MySQLContext context)
        {
            _context = context;
            dataset = _context.Set<Book>();
        }

        // Method responsible for returning all Books,
        public List<Book> FindAll()
        {
            return dataset.ToList();
        }
                
        public Book FindById(long id)
        {
            return _context.Books.SingleOrDefault(p => p.Id.Equals(id));
        }

        
        public Book Create(Book book)
        {
            try
            {
                dataset.Add(book);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return book;
        }

        
        public Book Update(Book book)
        {
            
            if (!Exists(book.Id)) return null;

            // Get the current status of the record in the database
            var result = dataset.SingleOrDefault(p => p.Id.Equals(book.Id));
            if (result != null)
            {
                try
                {
                    // set changes and save
                    _context.Entry(result).CurrentValues.SetValues(book);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return null;
            }
        }

        // Method responsible for deleting a book from an ID
        public void Delete(long id)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public bool Exists(long id)
        {
            return _context.Books.Any(p => p.Id.Equals(id));
        }
    }
}
