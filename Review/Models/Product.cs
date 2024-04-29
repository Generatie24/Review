namespace Review.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        
        List<Product> products = new List<Product>();

        public List<Product> GetProducts()
        {
            products.Add(new Product { Id = 1, Naam = "Apple", Prijs = 10.05m });
            products.Add(new Product { Id = 2, Naam = "Peer", Prijs = 7.45m });
            products.Add(new Product { Id = 3, Naam = "Tomato", Prijs = 12.55m });
            products.Add(new Product { Id = 4, Naam = "Potato", Prijs = 9.02m });
            return products;
        }
        public decimal Calculate()
        {
            var total = products.Sum(x => x.Prijs);
            return total;
        }
    }
}
