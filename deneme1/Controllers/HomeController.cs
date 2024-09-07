using EmployeAPI.Data;
using EmployeAPI.ExtentionMethods;
using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        EmployeeContext _context;

        public HomeController(ILogger<HomeController> logger, EmployeeContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            #region view-bag-data
            ////ViewData
            //ViewData["StartPageValueViewData"] = "This is Start Page ViewData";
            ////ViewBag
            //ViewBag.StartPageValue = "This is Start Page ViewBag";
            ////TempData
            //TempData["Id"] = 1;
            //TempData["Bootcamp"] = "Bootcamp - 1";

            //return RedirectToAction("About");
            #endregion


            #region LinqQueries
            //var data = from emp in _context.Employee select emp;

            #region 3 atlayıp 3 adet gösterme
            //var data = (from emp in _context.Employee
            //           where emp.EmployeeNumber >100
            //           select emp).Skip(3).Take(3);
            #endregion

            //var data = (from emp in _context.Employee
            //           where emp.EmployeeNumber >100
            //           orderby emp.EmployeeNumber descending
            //           select new Employee
            //           {
            //               EmployeeNumber = emp.EmployeeNumber,
            //               EmployeeId = emp.EmployeeId
            //           }
            //           );
            //return View(data.ToList());

            #endregion

            #region Extention Methods
            double a = 5;
             ViewBag.returnValue = a.IsInteger();
            #endregion

            #region Lambda Expression
            //Func<int, int> calculateSquare = CalSquare;
            //ViewBag.ResultsquareValue = calculateSquare(5);

            //Func<int, int> calculateSquare = x=>x*x;
            //ViewBag.ResultsquareValue = calculateSquare(10);

            //Func<int, int, int> SumAllNumber = (x, y) => x + y;
            //ViewBag.ResultsquareValue = SumAllNumber(9,7);

            //var data = from emp in _context.Employee select emp;
            //data = data.Where(x => x.EmployeeNumber < 1000);


            //return View(data);

            //static int CalSquare(int number) {
            //    return number * number;
            //}
            #endregion

            #region Lambda Expression Examples

            //var data = _context.Employee.Where(x=>x.EmployeeNumber>1000).Select(e => new Employee
            //{
            //    EmployeeName = e.EmployeeName,
            //    EmployeeEmail = e.EmployeeEmail,
            //    EmployeeNumber = e.EmployeeNumber,
            //    EmployeeId = e.EmployeeId
            //})
            //    .Skip(1)
            //    .Take(2)
            //    .OrderByDescending(x => x.EmployeeName)
            //    .ToList();

            var data = _context.Employee.ToList();
            data = data.TakeWhile(x => x.EmployeeNumber<1250).ToList();     
            return View(data);
            #endregion
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
