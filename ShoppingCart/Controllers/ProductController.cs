﻿using Resources.Services;

namespace ShoppingCart.Controllers;

public class ProductController
{
    private readonly ProductService _productService;

    public ProductController(ProductService productService)
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
            bool productAdded = _productService.AddProduct(name, price);
            if (productAdded)
            {
                Console.WriteLine("Product added successfully.");
                _productService.SaveProducts();
            }
            else
            {
                Console.WriteLine("Product with the same name already exists");
            }

        }
        else
        {
            Console.WriteLine("Invalid price. Please enter a valid decimal number.");
        }
        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey();
    }
    public void ViewProducts()
    {
        var products = _productService.GetAllProducts();
        if (products.Count == 0)
        {
            Console.WriteLine("No products available");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nProduct list:");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Price: {product.Price:C}");
            }
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }
    }
    public void LoadProducts()
    {
        _productService.LoadProducts();
    }

    public void SaveProducts()
    {
        _productService.SaveProducts();
    }

}
