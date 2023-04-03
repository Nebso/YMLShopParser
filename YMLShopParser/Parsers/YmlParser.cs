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
        public ShopOffersDto Parse(string yml)
        {           
            var root = XElement.Parse(yml);
            var shop = root.Element("shop");

            var dto = new ShopOffersDto()
            {
                ShopName = shop?.Element("name")?.Value,
                ShopUrl = shop?.Element("url")?.Value
            };
            
            var offers =
                from offer in shop?.Element("offers")?.Elements("offer")
                select new 
                {                     
                    OfferId = Convert.ToInt32(offer?.Attribute("id")?.Value),
                    OfferName = offer?.Element("name")?.Value
                };               

            foreach (var offer in offers)
            {
                dto.Offers?.Add(new OfferDto { OfferId = offer.OfferId, OfferName = offer.OfferName });
            }

            return dto;
        }
    }
}
