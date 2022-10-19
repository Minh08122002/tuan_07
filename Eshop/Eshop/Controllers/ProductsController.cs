using Eshop.Data;
using Eshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class ProductsController : Controller
    {
        private EshopContext _context;

        public ProductsController(EshopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}
