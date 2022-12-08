using HCSpillage.Data;
using HCSpillage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HCSpillage.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataPresentation repository;
        private readonly UserManager<ApplicationDbUser> userManager;

        public HomeController(IDataPresentation repository, UserManager<ApplicationDbUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
 
            return View();
        }

        [AllowAnonymous]
        public IActionResult deviceData()
        {
            return View(repository.GetAllData());
        }
    }
}
