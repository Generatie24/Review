using Microsoft.AspNetCore.Mvc;
using Review.Models;
using System.Diagnostics;

namespace Review.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
