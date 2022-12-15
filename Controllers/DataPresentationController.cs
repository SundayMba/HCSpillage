using HCSpillage.Dtos;
using HCSpillage.Models;
using HCSpillage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HCSpillage.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DataPresentationController : Controller
    {
        private readonly IDataPresentation _dataStore;

        public DataPresentationController(IDataPresentation dataStore)
        {
            _dataStore = dataStore;
        }

        [HttpGet]
        public IActionResult GetAllData()
        {
            var data = _dataStore.GetAllData();
            return View(data);
        }

        public IActionResult GetViewersData()
        {
            return View(_dataStore.GetAllData());
        }

        [HttpGet]
        public IActionResult GetVerifiedDevice()
        {
            var device = _dataStore.GetVerifiedData();
            return View(device);
        }

        [HttpGet]
        public IActionResult GetUnVerifiedDevice()
        {
            var device = _dataStore.GetUnverifiedData();
            return View(device);
        }

        [HttpGet]
        public IActionResult CreateDevice()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllDeviceData()
        {
            var data = _dataStore.GetAllDeviceByData();
            return View(data);
        }

        [HttpPost]
        public IActionResult CreateDevice(UserAccountViewModelByAdmin model)
        {
            if(ModelState.IsValid)
            {
                var utcNow = DateTime.UtcNow;
                //var timezone = TimeZoneInfo.FindSystemTimeZoneById("West African Time");
                //var localDateTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, timezone);
                var device = new DataPresentation
                {
                    
                    DeviceId = model.DeviceId,
                    Location = model.Location,
                    Email = model.Email,
                    Config = false,
                    Data = "No",
                    Status = "OFF",
                    date = DateTime.Now.ToShortDateString(),
                    Time = DateTime.Now.ToShortDateString()
                };

                var createdDevice = _dataStore.CreateDevice(device);
                if (createdDevice != null)
                    return RedirectToAction("GetAllData");
            }

            return View(model);
        }


    }
}
