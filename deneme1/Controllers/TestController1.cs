using Microsoft.AspNetCore.Mvc;

namespace deneme1.Controllers
{
    public class TestController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string TestValue()
        {
            return "Test Value";
        }
    }
}
