using HCSpillage.Dtos;
using HCSpillage.Services;
using Microsoft.AspNetCore.Mvc;

namespace HCSpillage.Controllers
{
    [Route("api/device/")]
    public class DataPresentationController : Controller
    {
        private readonly IDataPresentation _dataStore;

        public DataPresentationController(IDataPresentation dataStore)
        {
            _dataStore = dataStore;
        }

        [HttpGet]
        [Route("get_all_device")]
        public IActionResult GetAllData()
        {
            var data = _dataStore.GetAllData();
            return View(data);
        }

        [Route("deviceData")]
        public IActionResult GetViewersData()
        {
            return View(_dataStore.GetAllData());
        }

        [HttpGet]
        [Route("verified_device")]
        public IActionResult GetVerifiedDevice()
        {
            var device = _dataStore.GetVerifiedData();
            return View(device);
        }

        [HttpGet]
        [Route("unverified_device")]
        public IActionResult GetUnVerifiedDevice()
        {
            var device = _dataStore.GetUnverifiedData();
            return View(device);
        }




    }
}
