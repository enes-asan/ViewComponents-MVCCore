using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponents.Models;

namespace ViewComponents.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        public NorthwindDbContext _context;
        public CategoryListViewComponent(NorthwindDbContext context)
        {
            _context = context;
        }
        public ViewViewComponentResult Invoke()
        {

            var categoryId =HttpContext.Request.Query["categoryId"];
            
            var model = new CategoryListViewModel
            {
                Categories = _context.Categories.ToList(),
                CategoryId=categoryId
            };
            return View(model);
        }
    }
}
