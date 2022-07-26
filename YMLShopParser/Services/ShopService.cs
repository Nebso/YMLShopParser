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
    internal class ShopService
    {
        private readonly HttpService http = new HttpService();
        private readonly IOfferRepository offerRepository = new EfRepository();
        private readonly IParser parser = new YmlParser();


        public void Save(string url, string shopID)
        {
            List<OfferDto> offerList = GetOffers(url, shopID);

        }

        public void Print(string shopID)
        {

        }

        private List<OfferDto> GetOffers(string url, string shopID)
        {
            string yml = http.GetYml(url).Result;
            return parser.Parse(yml);
        }

    }
}
