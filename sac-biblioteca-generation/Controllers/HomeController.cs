using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sac_biblioteca_generation.Database;
using sac_biblioteca_generation.Models;
using System.Diagnostics;

namespace sac_biblioteca_generation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (BookShopContext db = new BookShopContext())
            {
                List<Book> topThreeBooks = db.Books.Take(3).ToList();
                return View();
            }

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}