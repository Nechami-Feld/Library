using Library_API.IServices;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_API.Models;

namespace Library_API.Services
{
    public class BookService : IBookService
    {
        LibraryContext dbContext;
        public BookService(LibraryContext _db)
        {
            dbContext = _db;
        }
        public IEnumerable<Book> GetBooks()
        {
            return dbContext.Books;
        }
        public Book AddBook(Book book)
        {
            if (book != null)
            {
                dbContext.Books.Add(book);
                dbContext.SaveChanges();
                return book;
            }
            return null;
        }
        public Book UpdateBook(Book Book)
        {
            dbContext.Entry(Book).State = EntityState.Modified;
            dbContext.SaveChanges();
            return Book;
        }
        public Book DeleteBook(int id)
        {
            var book = dbContext.Books.FirstOrDefault(x => x.BookId == id);
            dbContext.Entry(book).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return book;
        }
        public IEnumerable<Book> GetBookByString(string search)
        {
            var books = dbContext.Books.Where(x => x.BookId == int.Parse(search));
            return books;
        }

       
    }
}
