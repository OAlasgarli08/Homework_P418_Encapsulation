using Practical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Services
{
    internal class BookService
    {
        public Book[] GetAll()
        {
            Book book1 = new()
            {
                id = 1,
                Name = "Test1",
                Author = "Author 1",
                PageCount = 100
            };

            Book book2 = new()
            {
                id = 2,
                Name = "Test2",
                Author = "Author 2",
                PageCount = 200
            };

            Book book3 = new()
            {
                id = 3,
                Name = "Test3",
                Author = "Author 3",
                PageCount = 300
            };

            return new Book[] { book1, book2, book3 };
        }

        public Book[] GetByAuthor(string author)
        {
            Book[] books = GetAll();

            Book[] filteredBooks = books.Where(m => m.Author == author).ToArray();

            return filteredBooks;
        }
        
        public Book GetById(int id)
        {
            Book[] books = GetAll();

            Book book = books.FirstOrDefault(m => m.id == id);

            return book;
        }
    }
}
