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
        private static readonly ShopService instance = new();
        private readonly HttpService _http;
        private readonly IRepository _offerRepository;
        private readonly IProvider _provider;

        private ShopService()
        {
            _http = new HttpService();
            _offerRepository = new EfRepository();
            _provider = new CsvConsolePrinter();
        }

        public static ShopService Instance => instance;

        public void Save(string url)
        {
            ShopOffersDto shopOffers = _http.GetOffers(url);
            _offerRepository.SaveAll(shopOffers);
        }

        public void Print(string shopName)
        {
            var shop = _offerRepository.GetShop(shopName);
            _provider.Provide(shop);
        }
    }
}
