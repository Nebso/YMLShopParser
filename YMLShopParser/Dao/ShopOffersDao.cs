using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Models;

namespace YMLShopParser.Dao
{
    public class ShopOffersDao
    {
        public Shop? Shop { get; set; }
        public List<Offer>? Offers { get; set; }
    }
}
