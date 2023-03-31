using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Dto;
using YMLShopParser.Parsers;

namespace YMLShopParser.Services
{
    public sealed class HttpService
    {
        private readonly HttpClient? _httpClient;
        private readonly IParser _parser;

        public HttpService()
        {
            _parser = new YmlParser();
        }

        internal ShopOffersDto GetOffers(string url)
        {
            string yml = GetYml(url);

            return _parser.Parse(yml);
        }

        private string GetYml(string? url)
        {
            if (url is null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            using var client = new HttpClient();
            var yml = client.GetStringAsync(url).ConfigureAwait(false).GetAwaiter().GetResult();     
            Console.WriteLine("YML doc downloaded successfully");

            return yml;
        }
    }
}
