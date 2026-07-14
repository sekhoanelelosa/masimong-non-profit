using masimong_non_profit.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace masimong_non_profit.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult Achivements() 
        {
            return View();
        }

    }

}