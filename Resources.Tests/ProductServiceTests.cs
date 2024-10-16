using Resources.Services;

namespace Resources.Tests;

public class ProductServiceTests
{
    [Fact]
    public void AddProduct_ShouldIncreaseProductCount()
    {
        //Arange
        var productService = new ProductService();
        int initialCount = productService.GetAllProducts().Count;

        //Act
        productService.AddProduct("TestProduct", 9.99m);
        int finalCount = productService.GetAllProducts().Count;

        //Assert
        Assert.Equal(initialCount + 1, finalCount);
    }
}
