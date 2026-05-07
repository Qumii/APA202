using _27_FrontToBackSqlConnection.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace _27_FrontToBackSqlConnection.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

       

        
    }
}
