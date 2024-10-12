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
            Console.WriteLine("3. Save products");
            Console.WriteLine("4. Exit");
            Console.Write("\nSelect an option (1-4): ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    _productController.AddProduct();
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                default:
                    Console.WriteLine("\nInvalid option. Please select an option between 1-4.");
                    Console.ReadKey();
                    break;
            }
        
        }

    }
}
