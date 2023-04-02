using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Models;

namespace YMLShopParser.Providers
{
    public interface IProvider
    {
        void Provide(Shop? shop);
    }
}
