using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMLShopParser.Dto
{
    public class ShopOffersDto
    {
        public string? ShopName { get; set; }        
        public string? ShopUrl { get; set; }
        public List<OfferDto>? Offers { get; set; }
    }
}
