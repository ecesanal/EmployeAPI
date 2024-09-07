using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("employee")]
	public class EmployeeController : Controller
	{
        [Route("startpage1")]
        [HttpGet()]
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

        [HttpGet]
        public JsonResult GetNames()
        {
            var names = new string[3]
            {
        "Ertug",
        "Hasan",
        "Bill"
            };

            return new JsonResult(Ok(names));
        }
        [Route("{value:int}")]
        public JsonResult PostName(int value)
        {
            return new JsonResult(Ok());
        }
        [HttpGet]
        public IActionResult SaveForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveForm(Employee emp)
        {
            return View(emp);
        }

    }

}
