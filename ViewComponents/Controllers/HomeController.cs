using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponents.Entites;
using ViewComponents.Models;

namespace ViewComponents.Controllers
{
    public class HomeController : Controller
    {
        public NorthwindDbContext _context;
        public HomeController(NorthwindDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var productList = new List<Product>();
            var categoryId = HttpContext.Request.Query["categoryId"];
            if (string.IsNullOrEmpty(categoryId))
            {
                productList = _context.Products.ToList();
            }
            else
            {
                productList = _context.Products.Where(p => p.CategoryId == int.Parse(categoryId)).ToList();
            }

            var productListViewModel = new ProductListViewModel
            {
                Products = productList,
            };
            return View(productListViewModel);
        }
    }
}
