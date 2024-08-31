using deneme1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace deneme1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //ViewData
            ViewData["StartPageValueViewData"] = "This is Start Page ViewData";
            //ViewBag
            ViewBag.StartPageValue = "This is Start Page ViewBag";
            //TempData
            TempData["Id"] = 1;
            TempData["Bootcamp"] = "Bootcamp - 1";

            return RedirectToAction("About");
        }

        public ActionResult About()
        {
            var viewDataValue = ViewData["This is Start Page ViewBag"] != null ? ViewData["This is Start Page ViewBag"] as string : string.Empty;
            var viewBagValue = ViewBag.StartPageValue != null ? ViewBag.StartPageValue as string : string.Empty;
            var IdValue = TempData["Id"] as string;
            var BootcampValue = TempData["Bootcamp"] as string;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
