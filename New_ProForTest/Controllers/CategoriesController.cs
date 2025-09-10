using Microsoft.AspNetCore.Mvc;
using New_ProForTest.Filters;

namespace New_ProForTest.Controllers
{
    [SessionAuthorize]
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
