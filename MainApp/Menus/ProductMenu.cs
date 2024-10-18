using Resources.Enums;
using Resources.Services;
using Resources.Models;
using System.Transactions;

namespace MainApp.Menus;

internal class ProductMenu
{

    private readonly ProductService _productService = new ProductService();

    public void CreateMenu()
    {
        Product product = new Product();
        Console.Clear();
        Console.WriteLine("Create new product");

        Console.Write("Enter Product Name: ");
        product.ProductName = Console.ReadLine() ?? "";

        Console.Write("Enter Product price: ");
        decimal.TryParse((Console.ReadLine() ?? ""), out decimal price);
        product.Price = price;


        var result = _productService.AddToList(product);

        switch (result)
        {
            case ResultStatus.Success:
                Console.WriteLine("\nProduct was created successfully.");
                break;

            case ResultStatus.Exists:
                Console.WriteLine("\nproduct with the same name already exists.");
                break;

            case ResultStatus.Failed:
                Console.WriteLine("\nSomething went wrong while creating the product.");
                break;

            case ResultStatus.SuccessWithErrors:
                Console.WriteLine("\nProduct was created successfully. But product list was not saved.");
                break;


        }


        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();

    }


    public void ViewAllMenu()
    {

        var productList = _productService.GetAllProducts();

        Console.Clear();
        Console.WriteLine("View all products\n");

        if (productList.Any())
        {
            foreach (Product product in productList)
            {
                Console.WriteLine($"Id: {product.Id} \nProduct name: {product.ProductName} \nPrice: {product.Price}kr\n");

            }

        }
        else
        {
            Console.WriteLine("No products in list\n");
        }
        Console.WriteLine("\nPress any key to continue.");
        Console.ReadKey();

    }

  
    


}



