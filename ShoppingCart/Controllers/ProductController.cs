using Resources.Services;

namespace ShoppingCart.Controllers;

public class ProductController
{
    private readonly ProductServices _productService;

    public ProductController(ProductServices productService)
    {
        _productService = productService;
    }
    public void AddProduct()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter product price: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            _productService.AddProduct(name, price);
            Console.WriteLine("Product added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid price. Please enter a valid decimal number.");
        }
        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey();
    }
}
