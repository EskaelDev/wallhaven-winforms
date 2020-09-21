using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace wallpaper_forms.Services
{
    public class ImageService : IImageService
    {
        private readonly ILogger<RequestService> _log;
        private readonly IConfiguration _config;

        public ImageService(ILogger<RequestService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }
        public async Task<Image> GetImage(string url)
        {
            _log.LogDebug("Downloading thumbnail");
            WebClient client = new WebClient();
            Stream stream = await client.OpenReadTaskAsync(url);
            Bitmap bitmap;
            bitmap = new Bitmap(stream);
            return (Image)bitmap;

        }

    }
}