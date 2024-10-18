﻿using Resources.Services;

namespace Resources.Tests;

public class ProductServiceTests
{
    //Generated by ChatGPT o1-preview
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
