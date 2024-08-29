using Microsoft.AspNetCore.Mvc;
using Solvefy_Assessment.Data;


namespace Solvefy_Assesment.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Search/Index
        public IActionResult Index(string searchTerm)
        {
            var products = string.IsNullOrEmpty(searchTerm) ?
                _context.Products.ToList() :
                _context.Products.Where(p => p.Name.Contains(searchTerm)).ToList();

            return View(products);
        }
    }
}
