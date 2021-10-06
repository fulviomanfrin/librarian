using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using InfraData.Repository;

namespace Librarian.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller

        
    {
        private IBookRepository _repository;
      
        public BookController(IBookRepository repository)
        {
            _repository = repository;
        }
        

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_repository.FindAll());
        }

        
        [HttpGet("{id}")]
        public ActionResult Get(long id)
        {
            var book = _repository.FindById(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Book book)
        {
            if (book == null) return BadRequest();
            return Ok(_repository.Create(book));
        }


        [HttpPut]
        public ActionResult Put([FromBody] Book book)
        {
            if (book == null) return BadRequest();
            return Ok(_repository.Update(book));
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            _repository.Delete(id);
            return NoContent();
        }

        

    }
}
