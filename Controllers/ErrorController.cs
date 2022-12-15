using Microsoft.AspNetCore.Mvc;

namespace HCSpillage.Controllers
{
	public class ErrorController : Controller
	{
		[Route("Error/{statusCode}")]
		public IActionResult HttpErrorHandler(int statusCode)
		{
			return View(statusCode);
		}
	}
}
