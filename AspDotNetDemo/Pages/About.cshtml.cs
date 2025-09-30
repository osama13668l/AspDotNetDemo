using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace AspDotNetDemo.Pages
{
    public class AboutModel : PageModel
    {
        private List<Book> ListOfBooks;
        public string Title;
        public AboutModel()
        {
            Title = "About pages";
            ListOfBooks = new List<Book>()
            {
                new Book{ Id = 1, Title = "Learn C#", Author = "Safaa", Price = 24 },
                new Book{ Id = 2, Title = "Learn C ++", Author = "Ahmed", Price = 50 },
                new Book{ Id = 3, Title = "Learn java", Author = "Ali", Price = 20 }
            };
        }
        public void OnGet()
        {
            int id = 1;
        }
        public string GetTitle()
        {
            return Properties.Resources.AboutPageTitle;
        }
        public List<Book> GetBooks()
        {
            return ListOfBooks;
        }
    }
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

    }
}
