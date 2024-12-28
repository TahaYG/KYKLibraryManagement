using kyklibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace kyklibrary.Controllers
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
            return View();
        }

        public IActionResult Login(string email, string password)
        {
            return View();
        }

        public IActionResult Books(string username, string password)
        {
            // Check if email and password are "admin"
            if (username == "admin" && password == "admin")
            {
                // Redirect to a different page, for example to the Admin Dashboard
                return RedirectToAction("AdminDashboard");
            }
            else
            {
                // If credentials don't match, stay on the login page or show an error
                return View();
            }
        }

        public IActionResult AdminDashboard()
        {
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