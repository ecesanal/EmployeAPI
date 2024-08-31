using deneme1.Models;
using Microsoft.AspNetCore.Mvc;

namespace deneme1.Components
{
    public class Employee:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var emp = new List<EmployeeList>
            {
                new EmployeeList
                {
                    Id=1,
                    Name="Elif"
                },
                new EmployeeList
                {
                    Id=2,
                    Name="Ece"
                }
            };
            return View(emp);
        }    
    }
}
