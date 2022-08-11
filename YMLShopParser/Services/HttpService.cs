using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMLShopParser.Services
{
    internal class HttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService()
        {
            _httpClient = new HttpClient();
        }
         
        public async Task<string> GetYmlAsync(string? url)
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

            if (yml.Status == TaskStatus.Faulted)
            {
                throw new HttpRequestException("Download failed. Please verify correctness of provided URL or check your internet connection");
            }                

            Console.WriteLine("YML doc downloaded successfully");
            return await yml;
        }


    }
}
