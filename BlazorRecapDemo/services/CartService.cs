using BlazorRecapDemo.Models;

namespace BlazorRecapDemo.services
{
    public class CartService
    {
        public event Action OnCartChanged;
        public List<Product> CartItems { get; set; } = new List<Product>();
        public List<Product> AddToCart(Product product)
        {
         CartItems.Add(product);
            OnCartChanged?.Invoke();
            return CartItems;
        }

        public void Delete(Product product)
        {
          var item=  CartItems.FirstOrDefault(s => s.Id == product.Id);
            CartItems.Remove(item);
            OnCartChanged?.Invoke();
        }
        public void RemoveAllCart()
        {
            CartItems.Clear();
            OnCartChanged?.Invoke();
        }
    }
}
