using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Dto;
using YMLShopParser.Models;

namespace YMLShopParser.Repos
{
    public class EfRepository : IRepository
    {
        public void SaveAll(List<ShopOfferDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Shop FindShop(string name)
        {
            throw new NotImplementedException();
        }

        public List<Offer> FindOffers(Shop shop)
        {
            throw new NotImplementedException();
        }
    }
}
