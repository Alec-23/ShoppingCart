namespace ShoppingCart.Menus;

internal class Menu
{
    public void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("ShoppingCart Menu");
        Console.WriteLine("1. Add product");
        Console.WriteLine("2. View products");
        Console.WriteLine("3. Save products");
        Console.WriteLine("4. Exit");
        Console.Write("Select an option (1-4): ");

        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                break;

            case "2":
                break;

            case "3":
                break;

            case "4":
                break;

            default:
                Console.WriteLine("\nInvalid option. Please select 1-4.");
                Console.ReadKey();
                break;
        }

    }
}
