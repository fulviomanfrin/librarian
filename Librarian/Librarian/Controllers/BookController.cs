using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Librarian.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        // GET: BookController
        [HttpGet]
        public ActionResult GetBooks()
        {
            return View();
        }

        // GET: BookController/Details/5
        [HttpGet("{id}")]
        public ActionResult GetBook()
        {
            return View();
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        

        // GET: BookController/Edit/5
        

       

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookController/Delete/5
        
    }
}
