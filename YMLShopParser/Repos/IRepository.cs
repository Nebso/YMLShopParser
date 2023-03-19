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
    public interface IRepository
    {
        void SaveAll(List<ShopOfferDto> dtos);

        ShopOffersDao GetShop(string name);        
    }
}
