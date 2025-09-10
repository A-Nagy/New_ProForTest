using Microsoft.AspNetCore.Mvc;
using New_ProForTest.Repository.Base;
using System.Reflection.Metadata;

namespace New_ProForTest.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IUintOfWork _unitOfWork;
        public AccountsController(IUintOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index() 
        {
            return View(); 
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username , string password)
        {
            var user = _unitOfWork.Employees.Login(username, password);
            if (user != null)
            {
                // Store user information in session
                 HttpContext.Session.SetString("UserName", username);
                 HttpContext.Session.SetString("UserId", user.Id.ToString());
                // Redirect to a secure area or dashboard
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password";
                return View();
            }
            
        }


        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
    }
}
