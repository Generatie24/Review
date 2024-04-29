using Microsoft.AspNetCore.Mvc;
using Review.Models;

namespace Review.Controllers
{
    public class StrongController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Product product = new Product();
           
            return View(product);
        }

        //[HttpPost]
        //public IActionResult Index(Product product)
        //{
        //    return View();
        //}
    }
}
