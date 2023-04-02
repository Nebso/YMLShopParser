using YMLShopParser.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
class Program
{
    private static ArgsService? _argsService;
    static void Main(string[] args)
    {
        // #TODO: pack everything into DI container


        using IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
                services.AddSingleton<HttpService>()
                        .AddSingleton<ArgsService>()
                        .AddSingleton<ShopService>())
        .Build();

        host.Run();

        //_argsService = new ArgsService(args);
        //_argsService.ParseArgs();
    }
}





