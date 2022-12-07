using HCSpillage.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HCSpillage.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult RegisterByAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterByAdmin(UserAccountViewModelByAdmin userModel)
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegisterByUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterByUser(UserAccountViewModel userModel)
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }
    }
}
