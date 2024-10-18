using MainApp.Menus;

namespace MainApp.Menus;

internal class Menu
{
    private readonly ProductMenu _productMenu = new ProductMenu();
    public void MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("********************");
        Console.WriteLine("1. Add product");
        Console.WriteLine("2. View all products");
        Console.Write("Enter your choice:");

        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                _productMenu.CreateMenu();
                break;
            case "2":
                _productMenu.ViewAllMenu();
                break;
            case "3":
                break;
            case "4":
                break;

            default:
                Console.WriteLine();
                Console.WriteLine("Incorrect choice, please try again by pressing any key.");
                Console.ReadKey();
                break;



        }




    }
}
