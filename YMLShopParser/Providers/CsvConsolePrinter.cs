using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Models;

namespace YMLShopParser.Providers
{
    internal class CsvConsolePrinter : IProvider
    {
        public void Provide(Shop? shop)
        {
            if (shop is null) throw new ArgumentNullException(nameof(shop));

            var csv = new StringBuilder();

            csv.AppendLine("id;name");
          
            foreach (var offer in shop.Offers!)
            {
                csv.AppendLine($"{offer.Id};{offer.Name}");
            }

            Console.WriteLine(csv.ToString());
        }
    }
}
