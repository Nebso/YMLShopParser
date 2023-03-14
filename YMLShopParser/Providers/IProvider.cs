using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Dao;

namespace YMLShopParser.Providers
{
    public interface IProvider
    {
        void Provide(ShopOffersDao shop);
    }
}
