using HCSpillage.Data;
using HCSpillage.Dtos;
using HCSpillage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HCSpillage.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationDbUser> userManager;
        private readonly SignInManager<ApplicationDbUser> signInManager;
        private readonly IDataPresentation repository;

        public AccountController(UserManager<ApplicationDbUser> userManager, 
                                SignInManager<ApplicationDbUser> signInManager, 
                                IDataPresentation repository)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.repository = repository;
        }

        
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

        [AllowAnonymous]
        [HttpGet]
        public IActionResult RegisterByUser()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> RegisterByUser(UserAccountViewModel userModel)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationDbUser
                {
                    UserName = userModel.Email,
                    Email = userModel.Email,
                    DeviceId = userModel.DeviceId,
                    DeviceToken = userModel.DeviceToken,

                };

                var result = await userManager.CreateAsync(user, userModel.Password);

                if(result.Succeeded)
                {
                   await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
              var result =  await signInManager.PasswordSignInAsync(model.UserName, model.Password, 
                               isPersistent: false, false);

                if(result.Succeeded)
                {
                    return RedirectToAction("GetAllData", "DataPresentation");
                }

                ModelState.AddModelError(string.Empty, errorMessage: "Invalid login Attempt");
                    
            }
            return View(model);
        }
    }
}
