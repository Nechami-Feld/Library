using Library_API.IServices;
using Library_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookService bookService;
        public BookController(IBookService book)
        {
            bookService = book;
        }
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return bookService.GetBooks();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/book/AddBook")]
        public Book Addbook(Book book)
        {
            return bookService.AddBook(book);
        }
        [HttpPut]
        [Route("[action]")]
        [Route("api/book/EditBook")]
        public Book Editbook(Book book)
        {
            return bookService.UpdateBook(book);
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/book/DeleteBook")]
        public Book Deletebook([FromQuery]int id)
        {
            return bookService.DeleteBook(id);
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/book/GetBookByString")]
        public IEnumerable<Book> GetBookByString([FromQuery]string search)
        {
            return bookService.GetBookByString(search);
        }
    }
}
