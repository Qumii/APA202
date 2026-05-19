using _27_FrontToBackSqlConnection.Areas.AdminPanel.ViewModels.Product;
using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection.Areas.AdminPanel.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env) 
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }


        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]

        //public async Task<IActionResult> Create(ProductCreateVM productCreateVM)
        //{

        //}
         
        public async Task<IActionResult> Update(int? id)
        {

            if (id is null || id < 1) return BadRequest();

            Product? product = await _context.Products.FirstOrDefaultAsync(p=>p.Id==id);
            if (product is null) return NotFound();

            ProductUpdateVM productUpdateVM = new()
            { 
                Name = product.Name,
                Price = product.Price,
                SKU = product.SKU,
                Description = product.Description,
                CategoryId = product.CategoryId,
                Categories= await _context.Categories.Where(c=> !c.IsDeleted).ToListAsync(),
            };

            return View(productUpdateVM);
        }
    }


}
