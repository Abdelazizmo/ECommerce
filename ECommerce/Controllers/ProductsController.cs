using ECommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ECommerceDbContext _context;
        public ProductsController(ECommerceDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            var Result = await _context.Products
                .Include(x=>x.Category).OrderBy(x=>x.Price)
                .ToListAsync();
            return View(Result);
        }
    }
}
