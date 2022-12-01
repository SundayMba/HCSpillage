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

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(DataPresentationDto device)
        {
            if(device == null) 
                return View();
             _dataStore.CreateDevice(device);
            return RedirectToAction("GetAllData");
        }

    }
}
