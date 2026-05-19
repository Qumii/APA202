using _27_FrontToBackSqlConnection.Data;
using Microsoft.AspNetCore.Mvc;

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
    }


}
