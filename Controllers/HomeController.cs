using HCSpillage.Data;
using HCSpillage.Models;
using HCSpillage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HCSpillage.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataPresentation repository;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(IDataPresentation repository, UserManager<ApplicationUser> userManager)
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

        [Authorize(Roles = "Customer")]
        [HttpGet]
        public IActionResult DashBoard(string deviceId)
        {
            string DeviceId = deviceId;
            List<DataPresentation> UserData = repository.GetAllDataByDeviceId(DeviceId);
            return View("UserDeviceInformation", UserData);
        }


        [Authorize(Roles = "Customer")]
        [HttpGet]
        public async Task<IActionResult> UserDeviceInformation(string Name)
        {
            var user = await userManager.FindByNameAsync(Name);
            List<DataPresentation> UserData = repository.GetAllDataByDeviceId(user.DeviceId);
            return View(UserData);
        }

        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
