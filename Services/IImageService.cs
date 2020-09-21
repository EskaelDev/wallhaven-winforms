using System.Drawing;
using System.Threading.Tasks;

namespace wallpaper_forms.Services
{
    public interface IImageService
    {
        Task<Image> GetImage(string url);
    }
}