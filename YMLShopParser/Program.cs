using YMLShopParser.Services;
class Program
{
    private static ShopService? shopService;

    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No arguments provided. Please enter a valid key such as \"-- save <shopId> <url>\" or \"-- print <shopId>\"");
            Console.WriteLine("Press any key to close the app");
            Console.ReadKey();
            return;
        }

        shopService = new ShopService();

        switch (args[1])
        {
            case "save":
                shopService.Save(args[2], args[3]);
                break;
            case "print":
                shopService.Print(args[2]);
                break;
            default:
                Console.WriteLine("Please enter a valid key such as \"-- save <shopId> <url>\" or \"-- print <shopId>\"");
                Console.WriteLine("Press any key to close the app");
                Console.ReadKey();
                break;
        }
    }
}





