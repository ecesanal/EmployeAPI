using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult GetTestValues() 
        {
            return View();
        }  public string TestValues() 
        {
            return "Test Value";
        }
        public PartialViewResult GetTestPartialValues() 
        {
            PartialViewResult result = PartialView();
            return result;
        }
        public JsonResult GetTestJsonValues()
        {
            JsonResult result = Json(
                new Employee
                {
                    EmployeeEmail = "ylmzz",
                    EmployeeName = "Test"
                });
            return result;
        }
        public EmptyResult GetTestEmptyValues() { 
        return new EmptyResult();
        }
        public ContentResult GetTestContentValues() { 
        ContentResult result = Content("Please not Empty Text");
            return result;
        }
    }
}
