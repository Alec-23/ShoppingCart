using Resources.Services;
using ShoppingCart.Controllers;

namespace ShoppingCart.Menus;

public class Menu
{
    private readonly ProductController _productController;

    public Menu()
    {
        var productService = new ProductServices();
        _productController = new ProductController(productService);
        _productController.LoadProducts();
    }

    public void ShowMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("ShoppingCart Menu");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. View products");
            Console.WriteLine("3. Exit");
            Console.Write("\nSelect an option (1-3): ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    _productController.AddProduct();
                    break;

                case "2":
                    _productController.ViewProducts();
                    break;

                case "3":
                    Console.WriteLine("Exiting the application.");
                    _productController.SaveProducts();
                    exit = true;
                    break;

                default:
                    Console.WriteLine("\nInvalid option. Please select an option between 1-4.");
                    Console.ReadKey();
                    break;
            }
        
        }

    }
}
