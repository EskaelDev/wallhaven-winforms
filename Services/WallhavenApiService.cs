using System;
using System.Net.Http;
using System.Threading.Tasks;
using wallpaper_forms.Models;

namespace wallpaper_forms.Services
{
    class WallhavenApiService
    {
        public async static Task<string> Get(string Uri, string body)
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
