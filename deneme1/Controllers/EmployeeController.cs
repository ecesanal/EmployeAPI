using deneme1.Models;
using Microsoft.AspNetCore.Mvc;

namespace deneme1.Controllers
{
	public class EmployeeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index([Bind(nameof(Employee.EmployeeName))]Employee emp)
		{
			if (ModelState.IsValid)
			{
				//Operations
			}
			var state = ModelState.ToList();
			return View();
		}
	}
}
