using Microsoft.AspNetCore.Mvc;

namespace _25_MVCIntro.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
