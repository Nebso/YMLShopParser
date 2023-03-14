using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Repos;
using YMLShopParser.Dto;
using YMLShopParser.Models;
using YMLShopParser.Parsers;

namespace YMLShopParser.Services
{
    public sealed class ShopService
    {
        private static readonly ShopService instance = new();
        private readonly HttpService _http;
        private readonly IRepository _offerRepository;
        private readonly IParser _parser;

        private ShopService()
        {
            _http = new HttpService();
            _offerRepository = new EfRepository();
            _parser = new YmlParser();
        }

        public static ShopService Instance => instance;

        public void Save(string url, string shopName)
        {

            List<ShopOfferDto> shopOffers = GetOffers(url);
            // TODO: save DTO to database 
        }

        public void Print(string shopName)
        {
            // TODO: get DAO from database and print it to console via CSV
        }

        private List<ShopOfferDto> GetOffers(string url)
        {
            string yml = _http.GetYmlAsync(url).ConfigureAwait(false).GetAwaiter().GetResult();      
            
            return _parser.Parse(yml);
        }       
    }
}
