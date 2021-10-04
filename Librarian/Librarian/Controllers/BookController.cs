using Microsoft.AspNetCore.Mvc;
using Librarian.Data;
using Domain.Models;
using System.Linq;

namespace Librarian.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller

        
    {
        private BookContext _context;
      
        public BookController(BookContext context)
        {
            _context = context;
        }
        

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.Books);
        }

        
        [HttpGet("{id}")]
        public ActionResult GetBiId(int id)
        {
            Book book = _context.Books.FirstOrDefault(book => book.Id == id);
            if(book != null)
            {
                return Ok(book);
            }
            return NotFound();
        }

       [HttpPost]
        public ActionResult Create([FromBody] Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return Ok();
        }

        
        //TODO DELETE
        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookController/Delete/5
        
    }
}
