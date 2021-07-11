using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HLAUtilities.Core.Services
{
    public static class HttpClientService
    {
        //Create thead safe singleton instance of HttpClient
        private static readonly Lazy<HttpClient> httpClient = new Lazy<HttpClient>(() => new HttpClient());
        public static HttpClient GetHttpClient()
        {
            return httpClient.Value;
        }
    }
}
