using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMLShopParser.Services
{
    internal class HttpService
    {
        public HttpService()
        {
            httpClient = new HttpClient();
        }

        private readonly HttpClient httpClient;

        public async Task<string> GetYml(string? url)
        {
            if (url is null) throw new ArgumentNullException(nameof(url));  
            Task<string> yml = httpClient.GetStringAsync(url);

            while (!yml.IsCompleted)
            {
                Console.Write("\rDownloading YML document...");
                await Task.Delay(1000);                
            }
            return await yml;
        }


    }
}
