using Microsoft.AspNetCore.Mvc;

namespace BoatProject.Contollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
