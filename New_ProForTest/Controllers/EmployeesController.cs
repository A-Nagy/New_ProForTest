using Microsoft.AspNetCore.Mvc;

namespace New_ProForTest.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
