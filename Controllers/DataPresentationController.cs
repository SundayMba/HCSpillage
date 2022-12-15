using HCSpillage.Dtos;
using HCSpillage.Models;
using HCSpillage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using HCSpillage.Time;

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
                DataPresentation presentation = _dataStore.GetDataByDeviceId(model.DeviceId);
                if(presentation != null) //device does't exist that has same device id
                {
                    ModelState.AddModelError(string.Empty, errorMessage: "Sorry, the selected device already exist");
                }else
                {
                    var device = new DataPresentation
                    {

                        DeviceId = model.DeviceId,
                        Location = model.Location,
                        Email = model.Email,
                        Config = false,
                        Data = "No",
                        Status = "OFF",
                        date = DateTime.Now.ToShortDateString(),
                        Time = TimeConversion.GetFormattedTime()
                    };


                    var createdDevice = _dataStore.CreateDevice(device);
                    if (createdDevice != null)
                        return RedirectToAction("GetAllData");

                }
                return View(model);

            }

            return View(model);
        }


    }
}
