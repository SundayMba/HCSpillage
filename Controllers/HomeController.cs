using HCSpillage.Services;
using Microsoft.AspNetCore.Mvc;

namespace HCSpillage.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataPresentation repository;

        public HomeController(IDataPresentation repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult deviceData()
        {
            return View(repository.GetAllData());
        }
    }
}
