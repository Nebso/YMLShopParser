using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMLParseStoreDeliver.Services
{
    internal class HttpService
    {
        public HttpService()
        {
            httpClient = new HttpClient { MaxResponseContentBufferSize = 1_000_000 };
        }

        private readonly HttpClient httpClient;




    }
}
