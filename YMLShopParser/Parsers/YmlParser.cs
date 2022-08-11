using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Dto;

namespace YMLShopParser.Parsers
{
    internal class YmlParser : IParser
    {
        public List<ShopDto> Parse(string yml)
        {
            var dto = new List<ShopDto>();
            
            foreach (var offer in yml)
            {
                dto.Add(yml, yml);
            }
            return dto;
        }
    }
}
