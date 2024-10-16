using Resources.Models;
using System.Text.Json;

namespace Resources.Services;

public class ProductService
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
    public List<Product> GetAllProducts()
    {
        return _products;
    }

    public void SaveProducts()
    {
        string json = JsonSerializer.Serialize(_products, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("products.json", json);
    }

    public void LoadProducts()
    {
        if (File.Exists("products.json"))
        {
            string json = File.ReadAllText("products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>(); 
        }
    }
}
