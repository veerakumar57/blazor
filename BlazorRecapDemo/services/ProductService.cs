using BlazorRecapDemo.Models;

namespace BlazorRecapDemo.services
{
    public class ProductService : IProductService
    {
        public async Task<Product> GetProductById(int id)
        {
            await Task.Delay(100);
            return GetProducts().FirstOrDefault(p => p.Id == id);

        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id=1, Name="Shoe", Description="Shoes for sports", ImageUrl="images/shoe.jpg", Brand="Nike", Price=1000},
                new Product { Id=2, Name="Laptop", Description="Laptop", ImageUrl="images/images.jpg", Brand="LP", Price=60000},
                new Product { Id=3, Name="Mobile", Description="Mobile devices for sale", ImageUrl="images/phone.jpg", Brand="Apple", Price=89800},
                new Product { Id=4, Name="Airpods", Description="Airpods", ImageUrl="images/airpods.jpg", Brand="Apple", Price=45000},
                new Product { Id=5, Name="Shirts", Description="Shirts for both men and women", ImageUrl="images/shirt3.jpg", Brand="Adidas", Price=7800},
            };
            return products;
        }
    }
}
