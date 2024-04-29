using Microsoft.AspNetCore.Mvc;

namespace Review.Controllers
{
    public class TestsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Hello = "Hello ";
            ViewData["World"] = "World!";
            return View();
        }

        public IActionResult Loop()
        {
            ViewBag.Numbers = new int[] { 1, 2, 3, 4, 5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };

            return View();
        }


    }
}
