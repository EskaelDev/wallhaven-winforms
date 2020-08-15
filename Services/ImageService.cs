using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace wallpaper_forms.Services
{
    public static class ImageService
    {

        public async static Task<Image> GetImage(string url)
        {
            WebClient client = new WebClient();
            Stream stream = await client.OpenReadTaskAsync(url);
            Bitmap bitmap;
            bitmap = new Bitmap(stream);
            return (Image)bitmap;

        }

    }
}