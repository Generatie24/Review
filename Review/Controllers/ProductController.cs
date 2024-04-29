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
            List<Product> producten = new List<Product>
            {
                new Product { Id = 1, Naam = "Apple", Prijs = 0.50m },
                new Product { Id = 2, Naam = "Brood", Prijs = 1.90m },
                new Product { Id = 3, Naam = "Kaas", Prijs = 2.50m },
                new Product { Id = 4, Naam = "Taart", Prijs = 4.80m }
            };
            decimal totaal = producten.Sum(p => p.Prijs);   
            ViewBag.Totaal = totaal;
            ViewBag.Producten = producten;
            ViewData["ProductenLijst"] = producten;
            ViewData["TotaalViewData"] = totaal;
            return View();
        }
    }
}
