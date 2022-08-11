using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Dao;
using YMLShopParser.Dto;
using YMLShopParser.Models;
using YMLShopParser.Parsers;

namespace YMLShopParser.Services
{
    public class ShopService
    {
        private readonly HttpService _http;
        private readonly IOfferRepository _offerRepository;
        private readonly IParser _parser;

        public ShopService()
        {
            _http = new HttpService();
            _offerRepository = new EfRepository();
            _parser = new YmlParser();
        }

        public void Save(string url, string shopId)
        {
            List<ShopDto> shopOffers = GetOffers(url);
            // TODO: save DTO to database 
        }

        public void Print(string shopID)
        {
            // TODO: get DAO from database and print it to console via CSV
        }

        private List<ShopDto> GetOffers(string url)
        {
            string yml = _http.GetYmlAsync(url).Result;            
            return _parser.Parse(yml);
        }       
    }
}
