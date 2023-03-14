using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Dto;
using System.Xml;
using System.Xml.Linq;

namespace YMLShopParser.Parsers
{
    internal class YmlParser : IParser
    {      
        public List<ShopOfferDto> Parse(string yml)
        {
            var dtos = new List<ShopOfferDto>();
            var root = XElement.Parse(yml);           
            var shopName = root.Element("shop")?.Element("name")?.Value;
            var shopUrl = root.Element("shop")?.Element("url")?.Value;

            var offers =
                from offer in root.Element("shop")?.Element("offers")?.Elements("offer")
                select new 
                {                     
                    OfferId = offer?.Attribute("id")?.Value,
                    OfferName = offer?.Element("name")?.Value
                };               

            foreach (var offer in offers)
            {
                dtos.Add(new ShopOfferDto { ShopName = shopName, ShopUrl = shopUrl, OfferId = offer.OfferId, OfferName = offer.OfferName });
            }

            return dtos;
        }
    }
}
