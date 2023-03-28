using Library_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_API.IServices
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        IEnumerable<Book> GetBookByString(string search);
        Book AddBook(Book employee);
        Book UpdateBook(Book employee);
        Book DeleteBook (int id);
    }
}
