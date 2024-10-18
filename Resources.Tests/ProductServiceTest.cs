using Resources.Enums;
using Resources.Models;
using Resources.Services;

namespace Resources.Tests;

public class ProductServiceTest
{
    
    [Fact]
    public void AddToList_ShouldReturnSuccess_WhenProductAddedToList()
    {

        Product product = new Product { ProductName = "Mobil", Price = 1234 };
        ProductService productService = new ProductService();

        ResultStatus result = productService.AddToList(product);

        var productList = productService.GetAllProducts();

        Assert.Equal(ResultStatus.Success, result);
        Assert.Single(productList);




    }

}




