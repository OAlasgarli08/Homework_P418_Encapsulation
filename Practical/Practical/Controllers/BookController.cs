using Practical.Models;
using Practical.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Controllers
{
    internal class BookController
    {
       private BookService bookService;
        public BookController() 
        { 
            bookService = new BookService();
        } 

        public void GetAllByAuthor()
        {
            string authorname = "Author 1";           

            Book[] result = bookService.GetByAuthor(authorname);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Author}");
            }
        }

        public void GetAllByID()
        {
            int id = 2;

            var result = bookService.GetById(id);

            Console.WriteLine(result.Name + "-" + result.Author + "-" + result.PageCount);
        }

    }
}
