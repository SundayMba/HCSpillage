using HCSpillage.Data;
using HCSpillage.Dtos;
using HCSpillage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HCSpillage.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IDataPresentation repository;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<ApplicationUser> userManager, 
                                SignInManager<ApplicationUser> signInManager, 
                                IDataPresentation repository, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.repository = repository;
            this.roleManager = roleManager;
        }

        [HttpGet]
       public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
               var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if(result.Succeeded)
                {
                    var user = await userManager.FindByEmailAsync(model.Email);
                  
                    
                    if(await userManager.IsInRoleAsync(user, "Admin"))
                    {
                        return RedirectToAction("GetAllData", "DataPresentation");
                    }
                    else
                    {
                       
                        if (user != null)
                        {
                            
                            return RedirectToAction("DashBoard", "home", new { deviceId = user.DeviceId});
                        }
                        
                    }
                    
                }

                ModelState.AddModelError("", "Invalid Login Attempt");
                return View();
                
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserAccountViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var deviceUser = repository.GetDataByDeviceId(model.DeviceId);

            if(deviceUser == null)
            {
                ModelState.AddModelError(string.Empty, "Device does not Exist");
            }else
                { 
                if(deviceUser.Email == model.Email)
                {
                    repository.VerifyDevice(deviceUser);
                    var user = new ApplicationUser
                    {
                        Email = model.Email,
                        UserName = model.Email,
                        DeviceId = model.DeviceId
                    };

                    var result = await userManager.CreateAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, "Customer");
                        await signInManager.SignInAsync(user, false);
                        return RedirectToAction("index", "home");
                    }

                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            ModelState.AddModelError(string.Empty, "Provided device does not match Registered Email");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
           await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

    }
}
