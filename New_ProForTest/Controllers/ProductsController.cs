using Microsoft.AspNetCore.Mvc;

namespace New_ProForTest.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
