using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Dto;
using YMLShopParser.Parsers;

namespace YMLShopParser.Services
{
    internal sealed class HttpService
    {
        private readonly HttpClient _httpClient;
        private readonly IParser _parser;

        public HttpService()
        {
            _httpClient = new HttpClient();
            _parser = new YmlParser();
        }

        internal List<ShopOfferDto> GetOffers(string url)
        {
            string yml = GetYmlAsync(url).ConfigureAwait(false).GetAwaiter().GetResult();

            return _parser.Parse(yml);
        }

        private async Task<string> GetYmlAsync(string? url)
        {
            if (url is null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            Task<string> yml = _httpClient.GetStringAsync(url);

            while (!yml.IsCompleted)
            {
                Console.Write("\rDownloading YML document...");
                await Task.Delay(1000);                
            }

            if (yml.Status is TaskStatus.Faulted)
            {
                throw new HttpRequestException("Download failed. Please verify the provided YML address or check your internet connection");
            }                

            Console.WriteLine("YML doc downloaded successfully");
            _httpClient.Dispose();

            return await yml;
        }


    }
}
