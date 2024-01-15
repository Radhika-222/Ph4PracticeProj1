using Microsoft.AspNetCore.Mvc;

namespace Ph4PracticeProj1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "Sam" && password == "sam@1256")
            {
                return RedirectToAction("Dashboard");
            }
            ViewBag.ErrorMessage = "Invalid username or password";
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}
