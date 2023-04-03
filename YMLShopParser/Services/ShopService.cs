using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Repos;
using YMLShopParser.Dto;
using YMLShopParser.Providers;

namespace YMLShopParser.Services
{
    public sealed class ShopService
    {              
        private readonly IRepository _offerRepository;
        private readonly IProvider _provider;
        private readonly HttpService _http;

        public ShopService()
        {
            _offerRepository = new EfRepository();
            _provider = new CsvConsolePrinter();
            _http = new HttpService();
        }

        public void Start(string[] args)
        {
            var command = ArgsService.ParseArgs(args);

            switch (command)
            {
                case CliArgs.Save:
                    Save(args[1]);
                    break;
                case CliArgs.Print:
                    Print(args[1]);
                    break;
                case CliArgs.Default:
                    return;
            }
        }

        private void Save(string url)
        {
            ShopOffersDto shopOffers = _http.GetOffers(url);
            _offerRepository.SaveAll(shopOffers);
        }

        private void Print(string shopName)
        {
            var shop = _offerRepository.GetShop(shopName);
            _provider.Provide(shop);
        }
    }
}
