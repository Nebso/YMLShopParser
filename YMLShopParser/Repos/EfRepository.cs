using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Dao;
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

        public ShopOffersDao GetShop(string name)
        {
            var shopOffersDao = new ShopOffersDao()
            {
                Shop = FindShop(name)
            };

            shopOffersDao.Offers = FindOffers(shopOffersDao.Shop);

            return shopOffersDao;
        }

        private Shop FindShop(string name)
        {
            throw new NotImplementedException();
        }

        private List<Offer> FindOffers(Shop shop)
        {
            throw new NotImplementedException();
        }
    }
}
