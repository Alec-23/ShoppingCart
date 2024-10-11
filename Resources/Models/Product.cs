namespace Resources.Models;

internal class Product
{
    public Guid ID { get; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        ID = Guid.NewGuid();
        Name = name;
        Price = price;
    }
}
