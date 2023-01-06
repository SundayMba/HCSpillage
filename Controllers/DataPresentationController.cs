using HCSpillage.Dtos;
using HCSpillage.Models;
using HCSpillage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using HCSpillage.Time;
using HCSpillage.Data;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace HCSpillage.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DataPresentationController : Controller
    {
        private readonly IDataPresentation _dataStore;
        private readonly UserManager<ApplicationUser> userManager;

        public DataPresentationController(IDataPresentation dataStore, UserManager<ApplicationUser> userManager)
        {
            _dataStore = dataStore;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult GetAllData()
        {
            var data = _dataStore.GetAllData();
            return View(data);
        }

        public IActionResult GetAllDataPDF()
        {
            var data = _dataStore.GetAllData();

            using (MemoryStream stream = new MemoryStream())
            {

                Document document = new Document(PageSize.A4, 0, 0, 20, 20);
                PdfWriter writer = PdfWriter.GetInstance(document, stream);
                document.Open();

                Paragraph header = new Paragraph("HCSPILLAGE SERVICES", new Font(Font.FontFamily.TIMES_ROMAN, 30));
                header.Alignment = Element.ALIGN_CENTER;
                header.SpacingAfter = 20;
                document.Add(header);

                PdfPTable table = new PdfPTable(7);

                PdfPCell cell1 = new PdfPCell(new Phrase("DeviceId", new Font(Font.FontFamily.TIMES_ROMAN, 15)));
                cell1.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell1.BorderWidthBottom = 1f;
                cell1.BorderWidthTop = 1f;
                cell1.BorderWidthLeft = 1f;
                cell1.BorderWidthRight = 1f;
                cell1.VerticalAlignment = Element.ALIGN_CENTER;
                cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                cell1.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell1);

                PdfPCell cell2 = new PdfPCell(new Phrase("Location", new Font(Font.FontFamily.TIMES_ROMAN, 15)));
                cell2.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell2.BorderWidthBottom = 1f;
                cell2.BorderWidthTop = 1f;
                cell2.BorderWidthLeft = 1f;
                cell2.BorderWidthRight = 1f;
                cell2.VerticalAlignment = Element.ALIGN_CENTER;
                cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                cell2.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell2);

                PdfPCell cell3 = new PdfPCell(new Phrase("Data", new Font(Font.FontFamily.TIMES_ROMAN, 15)));
                cell3.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell3.BorderWidthBottom = 1f;
                cell3.BorderWidthTop = 1f;
                cell3.BorderWidthLeft = 1f;
                cell3.BorderWidthRight = 1f;
                cell3.VerticalAlignment = Element.ALIGN_CENTER;
                cell3.HorizontalAlignment = Element.ALIGN_CENTER;
                cell3.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell3);

                PdfPCell cell4 = new PdfPCell(new Phrase("Status", new Font(Font.FontFamily.TIMES_ROMAN, 15)));

                cell4.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell4.BorderWidthBottom = 1f;
                cell4.BorderWidthTop = 1f;
                cell4.BorderWidthLeft = 1f;
                cell4.BorderWidthRight = 1f;
                cell4.VerticalAlignment = Element.ALIGN_CENTER;
                cell4.HorizontalAlignment = Element.ALIGN_CENTER;
                cell4.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell4);

                PdfPCell cell5 = new PdfPCell(new Phrase("Date", new Font(Font.FontFamily.TIMES_ROMAN, 15)));

                cell5.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell5.BorderWidthBottom = 1f;
                cell5.BorderWidthTop = 1f;
                cell5.BorderWidthLeft = 1f;
                cell5.BorderWidthRight = 1f;
                cell5.VerticalAlignment = Element.ALIGN_CENTER;
                cell5.HorizontalAlignment = Element.ALIGN_CENTER;
                cell5.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell5);

                PdfPCell cell6 = new PdfPCell(new Phrase("Time", new Font(Font.FontFamily.TIMES_ROMAN, 15)));

                cell6.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell6.BorderWidthBottom = 1f;
                cell6.BorderWidthTop = 1f;
                cell6.BorderWidthLeft = 1f;
                cell6.BorderWidthRight = 1f;
                cell6.VerticalAlignment = Element.ALIGN_CENTER;
                cell6.HorizontalAlignment = Element.ALIGN_CENTER;
                cell6.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell6);

                PdfPCell cell7 = new PdfPCell(new Phrase("Config", new Font(Font.FontFamily.TIMES_ROMAN, 15)));

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
                    PdfPCell col1 = new PdfPCell(new Phrase(device.DeviceId));
                    PdfPCell col2 = new PdfPCell(new Phrase(device.Location));
                    PdfPCell col3 = new PdfPCell(new Phrase(device.Data));
                    PdfPCell col4 = new PdfPCell(new Phrase(device.Status));
                    PdfPCell col5 = new PdfPCell(new Phrase(device.date));
                    PdfPCell col6 = new PdfPCell(new Phrase(device.Time));
                    PdfPCell col7 = new PdfPCell(new Phrase(device.Config.ToString()));

                    col1.HorizontalAlignment = Element.ALIGN_CENTER;
                    col2.HorizontalAlignment = Element.ALIGN_CENTER;
                    col3.HorizontalAlignment = Element.ALIGN_CENTER;
                    col4.HorizontalAlignment = Element.ALIGN_CENTER;
                    col5.HorizontalAlignment = Element.ALIGN_CENTER;
                    col6.HorizontalAlignment = Element.ALIGN_CENTER;
                    col7.HorizontalAlignment = Element.ALIGN_CENTER;

                    table.AddCell(col1);
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
                return File(constant, "Application/vnd", "AllDeviceData.pdf");

            }
}
        public IActionResult GetViewersData()
        {
            return View(_dataStore.GetAllData());
        }

        public IActionResult GetViewersDataPDF()
        {
            var data = _dataStore.GetAllData();

            using (MemoryStream stream = new MemoryStream())
            {

                Document document = new Document(PageSize.A4, 0, 0, 20, 20);
                PdfWriter writer = PdfWriter.GetInstance(document, stream);
                document.Open();

                Paragraph header = new Paragraph("HCSPILLAGE SERVICES", new Font(Font.FontFamily.TIMES_ROMAN, 30));
                header.Alignment = Element.ALIGN_CENTER;
                header.SpacingAfter = 20;
                document.Add(header);

                PdfPTable table = new PdfPTable(7);

                PdfPCell cell1 = new PdfPCell(new Phrase("DeviceId", new Font(Font.FontFamily.TIMES_ROMAN, 20)));
                cell1.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell1.BorderWidthBottom = 1f;
                cell1.BorderWidthTop = 1f;
                cell1.BorderWidthLeft = 1f;
                cell1.BorderWidthRight = 1f;
                cell1.VerticalAlignment = Element.ALIGN_CENTER;
                cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                cell1.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell1);

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

                PdfPCell cell4 = new PdfPCell(new Phrase("Status", new Font(Font.FontFamily.TIMES_ROMAN, 10)));

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
                    PdfPCell col1 = new PdfPCell(new Phrase(device.DeviceId));
                    PdfPCell col2 = new PdfPCell(new Phrase(device.Location));
                    PdfPCell col3 = new PdfPCell(new Phrase(device.Data));
                    PdfPCell col4 = new PdfPCell(new Phrase(device.Status));
                    PdfPCell col5 = new PdfPCell(new Phrase(device.date));
                    PdfPCell col6 = new PdfPCell(new Phrase(device.Time));
                    PdfPCell col7 = new PdfPCell(new Phrase(device.Config.ToString()));

                    col1.HorizontalAlignment = Element.ALIGN_CENTER;
                    col2.HorizontalAlignment = Element.ALIGN_CENTER;
                    col3.HorizontalAlignment = Element.ALIGN_CENTER;
                    col4.HorizontalAlignment = Element.ALIGN_CENTER;
                    col5.HorizontalAlignment = Element.ALIGN_CENTER;
                    col6.HorizontalAlignment = Element.ALIGN_CENTER;
                    col7.HorizontalAlignment = Element.ALIGN_CENTER;

                    table.AddCell(col1);
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
                return File(constant, "Application/vnd", "AllDeviceData.pdf");

            }
        }

        [HttpGet]
        public IActionResult GetVerifiedDevice()
        {
            var device = _dataStore.GetVerifiedData();
            return View(device);
        }

        public IActionResult GetVerifiedDevicePDF()
        {
            var data = _dataStore.GetVerifiedData();

            using (MemoryStream stream = new MemoryStream())
            {

                Document document = new Document(PageSize.A4, 0, 0, 20, 20);
                PdfWriter writer = PdfWriter.GetInstance(document, stream);
                document.Open();

                Paragraph header = new Paragraph("HCSPILLAGE SERVICES", new Font(Font.FontFamily.TIMES_ROMAN, 30));
                header.Alignment = Element.ALIGN_CENTER;
                header.SpacingAfter = 20;
                document.Add(header);

                PdfPTable table = new PdfPTable(5);

                PdfPCell cell1 = new PdfPCell(new Phrase("DeviceId", new Font(Font.FontFamily.TIMES_ROMAN, 20)));
                cell1.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell1.BorderWidthBottom = 1f;
                cell1.BorderWidthTop = 1f;
                cell1.BorderWidthLeft = 1f;
                cell1.BorderWidthRight = 1f;
                cell1.VerticalAlignment = Element.ALIGN_CENTER;
                cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                cell1.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell1);

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

                PdfPCell cell7 = new PdfPCell(new Phrase("Verified", new Font(Font.FontFamily.TIMES_ROMAN, 20)));

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
                    PdfPCell col1 = new PdfPCell(new Phrase(device.DeviceId));
                    PdfPCell col2 = new PdfPCell(new Phrase(device.Location));
                    PdfPCell col5 = new PdfPCell(new Phrase(device.date));
                    PdfPCell col6 = new PdfPCell(new Phrase(device.Time));
                    PdfPCell col7 = new PdfPCell(new Phrase(device.Verify.ToString()));

                    col1.HorizontalAlignment = Element.ALIGN_CENTER;
                    col2.HorizontalAlignment = Element.ALIGN_CENTER;
                    col5.HorizontalAlignment = Element.ALIGN_CENTER;
                    col6.HorizontalAlignment = Element.ALIGN_CENTER;
                    col7.HorizontalAlignment = Element.ALIGN_CENTER;

                    table.AddCell(col1);
                    table.AddCell(col2);
                    table.AddCell(col5);
                    table.AddCell(col6);
                    table.AddCell(col7);
                }

                document.Add(table);
                document.Close();
                writer.Close();
                var constant = stream.ToArray();
                return File(constant, "Application/vnd", "AllVerifiedData.pdf");

            }
        }



        [HttpGet]
        public IActionResult GetUnVerifiedDevice()
        {
            var device = _dataStore.GetUnverifiedData();
            return View(device);
        }

        public IActionResult GetUnVerifiedDevicePDF()
        {
            var data = _dataStore.GetUnverifiedData();

            using (MemoryStream stream = new MemoryStream())
            {

                Document document = new Document(PageSize.A4, 0, 0, 20, 20);
                PdfWriter writer = PdfWriter.GetInstance(document, stream);
                document.Open();

                Paragraph header = new Paragraph("HCSPILLAGE SERVICES", new Font(Font.FontFamily.TIMES_ROMAN, 30));
                header.Alignment = Element.ALIGN_CENTER;
                header.SpacingAfter = 20;
                document.Add(header);

                PdfPTable table = new PdfPTable(5);

                PdfPCell cell1 = new PdfPCell(new Phrase("DeviceId", new Font(Font.FontFamily.TIMES_ROMAN, 20)));
                cell1.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell1.BorderWidthBottom = 1f;
                cell1.BorderWidthTop = 1f;
                cell1.BorderWidthLeft = 1f;
                cell1.BorderWidthRight = 1f;
                cell1.VerticalAlignment = Element.ALIGN_CENTER;
                cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                cell1.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell1);

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

                PdfPCell cell7 = new PdfPCell(new Phrase("Verified", new Font(Font.FontFamily.TIMES_ROMAN, 20)));

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
                    PdfPCell col1 = new PdfPCell(new Phrase(device.DeviceId));
                    PdfPCell col2 = new PdfPCell(new Phrase(device.Location));
                    PdfPCell col5 = new PdfPCell(new Phrase(device.date));
                    PdfPCell col6 = new PdfPCell(new Phrase(device.Time));
                    PdfPCell col7 = new PdfPCell(new Phrase(device.Verify.ToString()));

                    col1.HorizontalAlignment = Element.ALIGN_CENTER;
                    col2.HorizontalAlignment = Element.ALIGN_CENTER;
                    col5.HorizontalAlignment = Element.ALIGN_CENTER;
                    col6.HorizontalAlignment = Element.ALIGN_CENTER;
                    col7.HorizontalAlignment = Element.ALIGN_CENTER;

                    table.AddCell(col1);
                    table.AddCell(col2);
                    table.AddCell(col5);
                    table.AddCell(col6);
                    table.AddCell(col7);
                }

                document.Add(table);
                document.Close();
                writer.Close();
                var constant = stream.ToArray();
                return File(constant, "Application/vnd", "AllUnVerifiedData.pdf");

            }
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

        public IActionResult GetAllDeviceDataPDF()
        {
            var data = _dataStore.GetAllDeviceByData();

            using (MemoryStream stream = new MemoryStream())
            {

                Document document = new Document(PageSize.A4, 0, 0, 20, 20);
                PdfWriter writer = PdfWriter.GetInstance(document, stream);
                document.Open();

                Paragraph header = new Paragraph("HCSPILLAGE SERVICES", new Font(Font.FontFamily.TIMES_ROMAN, 30));
                header.Alignment = Element.ALIGN_CENTER;
                header.SpacingAfter = 20;
                document.Add(header);

                PdfPTable table = new PdfPTable(5);

                PdfPCell cell1 = new PdfPCell(new Phrase("DeviceId", new Font(Font.FontFamily.TIMES_ROMAN, 20)));
                cell1.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell1.BorderWidthBottom = 1f;
                cell1.BorderWidthTop = 1f;
                cell1.BorderWidthLeft = 1f;
                cell1.BorderWidthRight = 1f;
                cell1.VerticalAlignment = Element.ALIGN_CENTER;
                cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                cell1.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell1);

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

                PdfPCell cell7 = new PdfPCell(new Phrase("Verified", new Font(Font.FontFamily.TIMES_ROMAN, 20)));

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
                    PdfPCell col1 = new PdfPCell(new Phrase(device.DeviceId));
                    PdfPCell col2 = new PdfPCell(new Phrase(device.Location));
                    PdfPCell col5 = new PdfPCell(new Phrase(device.date));
                    PdfPCell col6 = new PdfPCell(new Phrase(device.Time));
                    PdfPCell col7 = new PdfPCell(new Phrase(device.Verify.ToString()));

                    col1.HorizontalAlignment = Element.ALIGN_CENTER;
                    col2.HorizontalAlignment = Element.ALIGN_CENTER;
                    col5.HorizontalAlignment = Element.ALIGN_CENTER;
                    col6.HorizontalAlignment = Element.ALIGN_CENTER;
                    col7.HorizontalAlignment = Element.ALIGN_CENTER;

                    table.AddCell(col1);
                    table.AddCell(col2);
                    table.AddCell(col5);
                    table.AddCell(col6);
                    table.AddCell(col7);
                }

                document.Add(table);
                document.Close();
                writer.Close();
                var constant = stream.ToArray();
                return File(constant, "Application/vnd", "AllDeviceData.pdf");

            }
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


        public IActionResult GetRegisteredUsers()
        {
            var AppUSer = userManager.Users;
            return View(AppUSer);
        }

        public IActionResult GetRegisteredUsersPDF()
        {
            var data = userManager.Users;

            using (MemoryStream stream = new MemoryStream())
            {

                Document document = new Document(PageSize.A4, 0, 0, 20, 20);
                PdfWriter writer = PdfWriter.GetInstance(document, stream);
                document.Open();

                Paragraph header = new Paragraph("HCSPILLAGE SERVICES", new Font(Font.FontFamily.TIMES_ROMAN, 30));
                header.Alignment = Element.ALIGN_CENTER;
                header.SpacingAfter = 20;
                document.Add(header);

                PdfPTable table = new PdfPTable(5);

                PdfPCell cell1 = new PdfPCell(new Phrase("DeviceId", new Font(Font.FontFamily.TIMES_ROMAN, 20)));
                cell1.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER;
                cell1.BorderWidthBottom = 1f;
                cell1.BorderWidthTop = 1f;
                cell1.BorderWidthLeft = 1f;
                cell1.BorderWidthRight = 1f;
                cell1.VerticalAlignment = Element.ALIGN_CENTER;
                cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                cell1.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell1);

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

                PdfPCell cell7 = new PdfPCell(new Phrase("Verified", new Font(Font.FontFamily.TIMES_ROMAN, 20)));

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
                    PdfPCell col1 = new PdfPCell(new Phrase(device.DeviceId));
                    PdfPCell col2 = new PdfPCell(new Phrase(device.Location));
                    PdfPCell col5 = new PdfPCell(new Phrase(device.Date));
                    PdfPCell col6 = new PdfPCell(new Phrase(device.Time));
                    PdfPCell col7 = new PdfPCell(new Phrase(device.Verify.ToString()));

                    col1.HorizontalAlignment = Element.ALIGN_CENTER;
                    col2.HorizontalAlignment = Element.ALIGN_CENTER;
                    col5.HorizontalAlignment = Element.ALIGN_CENTER;
                    col6.HorizontalAlignment = Element.ALIGN_CENTER;
                    col7.HorizontalAlignment = Element.ALIGN_CENTER;

                    table.AddCell(col1);
                    table.AddCell(col2);
                    table.AddCell(col5);
                    table.AddCell(col6);
                    table.AddCell(col7);
                }

                document.Add(table);
                document.Close();
                writer.Close();
                var constant = stream.ToArray();
                return File(constant, "Application/vnd", "AllRegisteredUsers.pdf");

            }
        }

        public IActionResult deviceDetails(string deviceId)
        {
            return RedirectToAction("Dashboard", "Home", new {deviceId = deviceId});
        }

    }
}
