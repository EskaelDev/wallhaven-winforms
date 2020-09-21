using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using wallpaper_forms.Models;

namespace wallpaper_forms.Services
{
    public class WallhavenApiService : IWallhavenApiService
    {
        private readonly ILogger<RequestService> _log;
        private readonly IConfiguration _config;

        public WallhavenApiService(ILogger<RequestService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }
        public async Task<string> Get(string Uri, string body)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(Uri),
                //Content = new StringContent(body, Encoding.UTF8, "application/json"),
            };
            var response = await client.SendAsync(request).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return responseBody;
        }

    }
}
