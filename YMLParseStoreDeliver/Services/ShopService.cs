using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLParseStoreDeliver.Dao;
using YMLParseStoreDeliver.Dto;
using YMLParseStoreDeliver.Models;
using YMLParseStoreDeliver.Parsers;

namespace YMLParseStoreDeliver.Services
{
    internal class ShopService
    {
        private readonly HttpService httpService = new HttpService();
        private readonly IOfferRepository offerRepository = new EfRepository();
        private readonly IParseable parser = new XmlParser();


        public void Save(int shopID, string url)
        {
            List<OfferDto> offerList = new List<OfferDto>();

        }

        public void Print(int shopID)
        {

        }
    }
}
