using Microsoft.AspNetCore.Mvc;

namespace _25_MVCIntro.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index ()
        {
            return View();
        }

        public int? Detail(int? id)
        {

            if (id is null || id<1)
            {
                throw new Exception("Id sehvdir");
            }
            return id;  
        }


        public string Error()
        {
            return "error";
        }
    }
}
