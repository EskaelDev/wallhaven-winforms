using System.Drawing;

namespace wallpaper_forms.Services
{
    public interface IWallpaperService
    {
        void SetWallpaper(Image image, WallpaperService.Style style);
    }
}