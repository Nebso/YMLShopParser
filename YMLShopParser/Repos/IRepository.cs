using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Dto;
using YMLShopParser.Models;

namespace YMLShopParser.Repos
{
    public interface IRepository
    {
        void SaveAll(ShopOffersDto dto);

        Shop? GetShop(string name);        
    }
}
