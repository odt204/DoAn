using Microsoft.AspNetCore.Mvc;

namespace WebTrangSuc.Controllers
{
	public class CategoryController : Controller 
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
