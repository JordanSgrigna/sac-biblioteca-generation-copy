using Microsoft.AspNetCore.Mvc;
using sac_biblioteca_generation.Models;
using sac_biblioteca_generation.Database;
using Microsoft.EntityFrameworkCore;

namespace sac_biblioteca_generation.Controllers
{
    public class BookController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            using(BookShopContext db = new BookShopContext())
            {
                List<Book> books = db.Books.Include(p => p.Genre).ToList();
                //List<Book> books = db.Books.ToList();
                return View(books);
            }
        }

        
         
        [HttpGet] 
        public IActionResult BookDetails(int id)
        {
            using (BookShopContext db = new BookShopContext())
            {
                Book? book = db.Books.Where(book => book.Id == id).Include(p => p.Genre.Nome).FirstOrDefault(); 
                if(book != null) 
                {
                    return View("BookDetails",  book);
                }
                else
                {
                    return NotFound($"Nessun libro trovato a questo indice {id}");
                }
            }

                
        }
         
         
    }
}
