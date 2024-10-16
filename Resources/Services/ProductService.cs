using Resources.Models;
using System.Text.Json;

namespace Resources.Services;

public class ProductService
{
    private List<Product> _products = new List<Product>();

    public bool AddProduct(string name, decimal price)
    {
        if (_products.Exists(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
        {
            return false;
        }

        var product = new Product(name, price);
        _products.Add(product);
        return true;
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
