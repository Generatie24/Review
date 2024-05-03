using Microsoft.AspNetCore.Mvc;
using Review.Models;

namespace Review.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Producten()
        {
            Product productModel = new Product();

           
            return View(productModel);
        }
    }
}
