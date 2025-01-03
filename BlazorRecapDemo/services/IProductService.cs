using BlazorRecapDemo.Models;

namespace BlazorRecapDemo.services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Task<Product> GetProductById(int id);
                    
    }
}
