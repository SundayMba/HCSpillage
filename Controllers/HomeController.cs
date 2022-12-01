using Microsoft.AspNetCore.Mvc;

namespace HCSpillage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
