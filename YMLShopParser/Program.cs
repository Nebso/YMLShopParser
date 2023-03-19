using YMLShopParser.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
class Program
{
    private static ShopService? s_shopService;

    static void Main(string[] args)
    {
        //using IHost host = Host.CreateDefaultBuilder(args)
        //    .ConfigureServices(services =>
        //        services.AddSingleton<HttpService>()
        //            .AddSingleton<ArgsService>()
        //            .AddSingleton<ShopService>())
        //.Build();

        //await host.RunAsync();





        if (args.Length == 0)
        {
            Console.WriteLine("No arguments provided. Please enter a valid key such as \"-- save <url>\" or \"-- print <shopId>\"");
            Console.WriteLine("Press any key to close the app");
            Console.ReadKey();

            return;
        }

        s_shopService = ShopService.Instance;

        switch (args[0].ToUpper())
        {
            case "SAVE":
                s_shopService.Save(args[1]);
                break;
            case "PRINT":
                s_shopService.Print(args[1]);
                break;
            default:
                Console.WriteLine("Please enter a valid key such as \"-- save <url>\" or \"-- print <shopId>\"");
                Console.WriteLine("Press any key to close the app");
                Console.ReadKey();
                break;
        }
    }
}





