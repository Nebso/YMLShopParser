using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Dao;
using YMLShopParser.Dto;
using YMLShopParser.Models;
using YMLShopParser.Data;

namespace YMLShopParser.Repos
{
    public class EfRepository : IRepository
    {
        public void SaveAll(ShopOffersDto dto)
        {
            using var db = new DataContext();
            
            db.Shops.Add(new Shop { Name = dto.ShopName, Url = dto.ShopUrl });
          
            var offers = from o in dto.Offers
                         select new Offer { Id = o.OfferId, Name = o.OfferName };

            db.Offers.AddRange(offers);
            db.SaveChanges();
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

        private Shop? FindShop(string name)
        {
            using var db = new DataContext();

            var shop = db.Shops.Find(name);

            return shop;
        }

        private List<Offer> FindOffers(Shop shop)
        {
            using var db = new DataContext();

            var offers = from o in db.Offers
                         where o.ShopName == shop.Name
                         select o;

            return offers.ToList();
        }
    }
}
