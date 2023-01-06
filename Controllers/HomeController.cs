using HCSpillage.Data;
using HCSpillage.Extensions;
using HCSpillage.Models;
using HCSpillage.Services;
using HCSpillage.Time;
using iTextSharp.text.pdf;
using iTextSharp.text;
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

        [Authorize(Roles = "Customer, Admin")]
        [HttpGet]
        public IActionResult DashBoard(string deviceId)
        {
            List<DataPresentation> UserData = repository.GetAllDataByDeviceId(deviceId);
            ViewData["deviceId"] = deviceId;
            return View("UserDeviceInformation", UserData);
        }


        [Authorize(Roles = "Customer")]
        [HttpGet]
        public async Task<IActionResult> UserDeviceInformation(string Name)
        {
            var user = await userManager.FindByNameAsync(Name);
            ViewData["deviceId"] = user.DeviceId;
            var UserData = repository.GetAllDataByDeviceId(user.DeviceId);
            return View(UserData);
        }

        [HttpPost("{deviceId}")]
        public IActionResult UserDeviceInformationPDF(string deviceId)
        {
            var data = repository.GetAllDataByDeviceId(deviceId);

            using (MemoryStream stream = new MemoryStream())
            {

                Document document = new Document(PageSize.A4, 0, 0, 20, 20);
                PdfWriter writer = PdfWriter.GetInstance(document, stream);
                document.Open();

                Paragraph header = new Paragraph("HCSPILLAGE SERVICES", new Font(Font.FontFamily.TIMES_ROMAN, 30));
                header.Alignment = Element.ALIGN_CENTER;
                header.SpacingAfter = 20;
                document.Add(header);

                PdfPTable table = new PdfPTable(6);

                PdfPCell cell2 = new PdfPCell(new Phrase("Location", new Font(Font.FontFamily.TIMES_ROMAN, 20)));
                cell2.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell2.BorderWidthBottom = 1f;
                cell2.BorderWidthTop = 1f;
                cell2.BorderWidthLeft = 1f;
                cell2.BorderWidthRight = 1f;
                cell2.VerticalAlignment = Element.ALIGN_CENTER;
                cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                cell2.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell2);

                PdfPCell cell3 = new PdfPCell(new Phrase("Data", new Font(Font.FontFamily.TIMES_ROMAN, 20)));
                cell3.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell3.BorderWidthBottom = 1f;
                cell3.BorderWidthTop = 1f;
                cell3.BorderWidthLeft = 1f;
                cell3.BorderWidthRight = 1f;
                cell3.VerticalAlignment = Element.ALIGN_CENTER;
                cell3.HorizontalAlignment = Element.ALIGN_CENTER;
                cell3.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell3);

                PdfPCell cell4 = new PdfPCell(new Phrase("Status", new Font(Font.FontFamily.TIMES_ROMAN, 20)));

                cell4.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell4.BorderWidthBottom = 1f;
                cell4.BorderWidthTop = 1f;
                cell4.BorderWidthLeft = 1f;
                cell4.BorderWidthRight = 1f;
                cell4.VerticalAlignment = Element.ALIGN_CENTER;
                cell4.HorizontalAlignment = Element.ALIGN_CENTER;
                cell4.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell4);

                PdfPCell cell5 = new PdfPCell(new Phrase("Date", new Font(Font.FontFamily.TIMES_ROMAN, 20)));

                cell5.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell5.BorderWidthBottom = 1f;
                cell5.BorderWidthTop = 1f;
                cell5.BorderWidthLeft = 1f;
                cell5.BorderWidthRight = 1f;
                cell5.VerticalAlignment = Element.ALIGN_CENTER;
                cell5.HorizontalAlignment = Element.ALIGN_CENTER;
                cell5.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell5);

                PdfPCell cell6 = new PdfPCell(new Phrase("Time", new Font(Font.FontFamily.TIMES_ROMAN, 20)));

                cell6.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell6.BorderWidthBottom = 1f;
                cell6.BorderWidthTop = 1f;
                cell6.BorderWidthLeft = 1f;
                cell6.BorderWidthRight = 1f;
                cell6.VerticalAlignment = Element.ALIGN_CENTER;
                cell6.HorizontalAlignment = Element.ALIGN_CENTER;
                cell6.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell6);

                PdfPCell cell7 = new PdfPCell(new Phrase("Config", new Font(Font.FontFamily.TIMES_ROMAN, 20)));

                cell7.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell7.BorderWidthBottom = 1f;
                cell7.BorderWidthTop = 1f;
                cell7.BorderWidthLeft = 1f;
                cell7.BorderWidthRight = 1f;
                cell7.VerticalAlignment = Element.ALIGN_CENTER;
                cell7.HorizontalAlignment = Element.ALIGN_CENTER;
                cell7.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell7);

                foreach (var device in data)
                {
                    PdfPCell col2 = new PdfPCell(new Phrase(device.Location));
                    PdfPCell col3 = new PdfPCell(new Phrase(device.Data));
                    PdfPCell col4 = new PdfPCell(new Phrase(device.Status));
                    PdfPCell col5 = new PdfPCell(new Phrase(device.date));
                    PdfPCell col6 = new PdfPCell(new Phrase(device.Time));
                    PdfPCell col7 = new PdfPCell(new Phrase(device.Config.ToString()));

                    col2.HorizontalAlignment = Element.ALIGN_CENTER;
                    col3.HorizontalAlignment = Element.ALIGN_CENTER;
                    col4.HorizontalAlignment = Element.ALIGN_CENTER;
                    col5.HorizontalAlignment = Element.ALIGN_CENTER;
                    col6.HorizontalAlignment = Element.ALIGN_CENTER;
                    col7.HorizontalAlignment = Element.ALIGN_CENTER;

                    table.AddCell(col2);
                    table.AddCell(col3);
                    table.AddCell(col4);
                    table.AddCell(col5);
                    table.AddCell(col6);
                    table.AddCell(col7);
                }

                document.Add(table);
                document.Close();
                writer.Close();
                var constant = stream.ToArray();
                return File(constant, "Application/vnd", "UserDevice.pdf");

            }
        }

        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            return View();
        }


        [Route("Api/devicedata")]
        [AllowAnonymous]
        public async Task<IActionResult> ApiHandler(ApiModel model)
        {
            if(ModelState.IsValid)
            {
                ApplicationUser device = await userManager.FindUserByDeviceId(model.DeviceId);
                if(device != null)
                {
                    if(device.Verify != true)
                    {
                        return Json("Device Not Verified");
                    }
                    DataPresentation deviceData = new DataPresentation
                    {
                        DeviceId = model.DeviceId,
                        Data = model.Data,
                        Status = model.Status,
                        Config = model.Config,
                        Verify = device.Verify,
                        Time = TimeConversion.GetFormattedTime(),
                        date = DateTime.Now.ToShortDateString(),
                        Location = device.Location,
                        Email = device.Email,                      
                    };

                    var result = repository.CreateDevice(deviceData);
                    if (result != null)
                    {
                        return Json("Data Logged successfully");
                    }
                        
                }

                return Json("Device ID specified does not exist");
            }

            return Json("Parameters not specified well");
            
        }
    }
}
