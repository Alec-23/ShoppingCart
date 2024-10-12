using Resources.Models;

namespace Resources.Services;

public class ProductServices
{
    private List<Product> _products = new List<Product>();

    public void AddProduct(string name, decimal price)
    {
        if (_products.Exists(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Product with the same name already exists.");
            return;
        }

        var product = new Product(name, price);
        _products.Add(product);
    }
}
